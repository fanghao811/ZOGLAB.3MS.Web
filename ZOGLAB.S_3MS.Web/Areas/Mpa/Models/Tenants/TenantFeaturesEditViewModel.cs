using Abp.AutoMapper;
using ZOGLAB.S_3MS.MultiTenancy;
using ZOGLAB.S_3MS.MultiTenancy.Dto;
using ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Common;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}