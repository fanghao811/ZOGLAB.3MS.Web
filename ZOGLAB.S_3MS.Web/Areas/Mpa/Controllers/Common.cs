using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Common.Modals;
using ZOGLAB.S_3MS.Web.Controllers;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : AbpZeroTemplateControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}