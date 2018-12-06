using System.Collections.Generic;
using ZOGLAB.S_3MS.Caching.Dto;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}