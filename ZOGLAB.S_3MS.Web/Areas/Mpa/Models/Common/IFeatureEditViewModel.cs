using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ZOGLAB.S_3MS.Editions.Dto;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}