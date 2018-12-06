using System.Web.Mvc;
using Abp.Auditing;

namespace ZOGLAB.S_3MS.Web.Controllers
{
    public class ErrorController : AbpZeroTemplateControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}