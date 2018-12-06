using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ZOGLAB.S_3MS.Authorization.Permissions.Dto;

namespace ZOGLAB.S_3MS.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}