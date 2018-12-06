using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ZOGLAB.S_3MS.Web.Controllers;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}