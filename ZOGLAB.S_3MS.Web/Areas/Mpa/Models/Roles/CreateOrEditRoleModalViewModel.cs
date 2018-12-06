using Abp.AutoMapper;
using ZOGLAB.S_3MS.Authorization.Roles.Dto;
using ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Common;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode
        {
            get { return Role.Id.HasValue; }
        }

        public CreateOrEditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}