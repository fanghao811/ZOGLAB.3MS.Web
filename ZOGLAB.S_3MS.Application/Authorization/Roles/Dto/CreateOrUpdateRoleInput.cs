﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace ZOGLAB.S_3MS.Authorization.Roles.Dto
{
    public class CreateOrUpdateRoleInput 
    {
        [Required]
        public RoleEditDto Role { get; set; }

        [Required]
        public List<string> GrantedPermissionNames { get; set; }
    }
}