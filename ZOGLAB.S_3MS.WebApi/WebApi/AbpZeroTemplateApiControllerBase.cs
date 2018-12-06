using Abp.WebApi.Controllers;

namespace ZOGLAB.S_3MS.WebApi
{
    public abstract class AbpZeroTemplateApiControllerBase : AbpApiController
    {
        protected AbpZeroTemplateApiControllerBase()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}