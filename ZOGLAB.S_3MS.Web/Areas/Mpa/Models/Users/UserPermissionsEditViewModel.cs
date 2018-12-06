using Abp.AutoMapper;
using ZOGLAB.S_3MS.Authorization.Users;
using ZOGLAB.S_3MS.Authorization.Users.Dto;
using ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Common;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}