using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Domain.Uow;
using Abp.UI;
using Abp.Zero;

namespace ZOGLAB.S_3MS.SD
{
    //TODO:完成TreeUnitManager的具体实现
    //参考:https://github.com/fanghao811/aspnetboilerplate/blob/dev/src/Abp.Zero.Common/Organizations/TreeUnitManager.cs:

    /// <summary>
    /// Performs domain logic for Organization Units.
    /// </summary>
    public class TreeUnitManager : DomainService
    {
        protected IRepository<TreeUnit, long> TreeUnitRepository { get; private set; }

        public TreeUnitManager(IRepository<TreeUnit, long> treeUnitRepository)
        {
            TreeUnitRepository = treeUnitRepository;

            LocalizationSourceName = AbpZeroConsts.LocalizationSourceName;
        }

        [UnitOfWork]
        public virtual async Task CreateAsync(TreeUnit treeUnit)
        {
            treeUnit.Code = await GetNextChildCodeAsync(treeUnit.ParentId);
            await ValidateTreeUnitAsync(treeUnit);
            await TreeUnitRepository.InsertAsync(treeUnit);
        }

        public virtual async Task UpdateAsync(TreeUnit treeUnit)
        {
            await ValidateTreeUnitAsync(treeUnit);
            await TreeUnitRepository.UpdateAsync(treeUnit);
        }

        public virtual async Task<string> GetNextChildCodeAsync(long? parentId)
        {
            var lastChild = await GetLastChildOrNullAsync(parentId);
            if (lastChild == null)
            {
                var parentCode = parentId != null ? await GetCodeAsync(parentId.Value) : null;
                return TreeUnit.AppendCode(parentCode, TreeUnit.CreateCode(1));
            }

            return TreeUnit.CalculateNextCode(lastChild.Code);
        }

        public virtual async Task<TreeUnit> GetLastChildOrNullAsync(long? parentId)
        {
            var children = await TreeUnitRepository.GetAllListAsync(ou => ou.ParentId == parentId);
            return children.OrderBy(c => c.Code).LastOrDefault();
        }

        public virtual async Task<string> GetCodeAsync(long id)
        {
            return (await TreeUnitRepository.GetAsync(id)).Code;
        }

        [UnitOfWork]
        public virtual async Task DeleteAsync(long id)
        {
            var children = await FindChildrenAsync(id, true);

            foreach (var child in children)
            {
                await TreeUnitRepository.DeleteAsync(child);
            }

            await TreeUnitRepository.DeleteAsync(id);
        }

        [UnitOfWork]
        public virtual async Task MoveAsync(long id, long? parentId)
        {
            var treeUnit = await TreeUnitRepository.GetAsync(id);
            if (treeUnit.ParentId == parentId)
            {
                return;
            }

            //Should find children before Code change
            var children = await FindChildrenAsync(id, true);

            //Store old code of OU
            var oldCode = treeUnit.Code;

            //Move OU
            treeUnit.Code = await GetNextChildCodeAsync(parentId);
            treeUnit.ParentId = parentId;

            await ValidateTreeUnitAsync(treeUnit);

            //Update Children Codes
            foreach (var child in children)
            {
                child.Code = TreeUnit.AppendCode(treeUnit.Code, TreeUnit.GetRelativeCode(child.Code, oldCode));
            }
        }

        public async Task<List<TreeUnit>> FindChildrenAsync(long? parentId, bool recursive = false)
        {
            if (!recursive)
            {
                return await TreeUnitRepository.GetAllListAsync(ou => ou.ParentId == parentId);
            }

            if (!parentId.HasValue)
            {
                return await TreeUnitRepository.GetAllListAsync();
            }

            var code = await GetCodeAsync(parentId.Value);

            return await TreeUnitRepository.GetAllListAsync(
                ou => ou.Code.StartsWith(code) && ou.Id != parentId.Value
            );
        }

        protected virtual async Task ValidateTreeUnitAsync(TreeUnit treeUnit)
        {
            var siblings = (await FindChildrenAsync(treeUnit.ParentId))
                .Where(ou => ou.Id != treeUnit.Id)
                .ToList();

            if (siblings.Any(ou => ou.DisplayName == treeUnit.DisplayName))
            {
                throw new UserFriendlyException(L("TreeUnitDuplicateDisplayNameWarning", treeUnit.DisplayName));
            }
        }
    }
}
