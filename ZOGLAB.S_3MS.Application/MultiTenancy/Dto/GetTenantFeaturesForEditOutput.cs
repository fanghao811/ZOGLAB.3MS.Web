using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ZOGLAB.S_3MS.Editions.Dto;

namespace ZOGLAB.S_3MS.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}