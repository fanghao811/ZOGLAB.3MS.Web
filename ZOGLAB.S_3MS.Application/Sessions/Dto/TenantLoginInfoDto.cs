using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ZOGLAB.S_3MS.MultiTenancy;

namespace ZOGLAB.S_3MS.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }

        public string EditionDisplayName { get; set; }

        public Guid? LogoId { get; set; }

        public string LogoFileType { get; set; }

        public Guid? CustomCssId { get; set; }
    }
}