using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ZOGLAB.S_3MS.Configuration.Host.Dto;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<ComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}