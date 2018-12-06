using System.Web.Mvc;

namespace ZOGLAB.S_3MS.Web.Controllers
{
    public class AboutController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}