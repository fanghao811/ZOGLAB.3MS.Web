﻿using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;

namespace ZOGLAB.S_3MS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ApplicationController : AbpZeroTemplateControllerBase
    {
        [DisableAuditing]
        public ActionResult Index()
        {
            /* Enable next line to redirect to Multi-Page Application */
            /* return RedirectToAction("Index", "Home", new {area = "Mpa"}); */

            return View("~/App/common/views/layout/layout.cshtml"); //Layout of the angular application.
        }
    }
}