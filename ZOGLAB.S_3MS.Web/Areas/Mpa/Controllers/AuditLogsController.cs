using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using ZOGLAB.S_3MS.Authorization;
using ZOGLAB.S_3MS.Web.Controllers;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}