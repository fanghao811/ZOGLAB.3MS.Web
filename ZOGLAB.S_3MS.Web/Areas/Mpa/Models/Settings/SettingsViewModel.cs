using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ZOGLAB.S_3MS.Configuration.Tenants.Dto;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}