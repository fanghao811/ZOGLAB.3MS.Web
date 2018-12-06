using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ZOGLAB.S_3MS.Authorization.Permissions.Dto;

namespace ZOGLAB.S_3MS.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
