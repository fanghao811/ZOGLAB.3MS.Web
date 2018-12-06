using System.Collections.Generic;
using ZOGLAB.S_3MS.Authorization.Permissions.Dto;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}