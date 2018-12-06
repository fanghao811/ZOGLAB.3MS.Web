using Abp.AutoMapper;
using ZOGLAB.S_3MS.Editions.Dto;
using ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Common;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionForEditOutput))]
    public class CreateOrEditEditionModalViewModel : GetEditionForEditOutput, IFeatureEditViewModel
    {
        public bool IsEditMode
        {
            get { return Edition.Id.HasValue; }
        }

        public CreateOrEditEditionModalViewModel(GetEditionForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}