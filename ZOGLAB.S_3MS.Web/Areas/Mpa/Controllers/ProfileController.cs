﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Configuration;
using Abp.Web.Mvc.Authorization;
using ZOGLAB.S_3MS.Authorization.Users.Profile;
using ZOGLAB.S_3MS.Timing;
using ZOGLAB.S_3MS.Timing.Dto;
using ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Profile;
using ZOGLAB.S_3MS.Web.Controllers;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : AbpZeroTemplateControllerBase
    {
        private readonly IProfileAppService _profileAppService;
        private readonly ITimingAppService _timingAppService;


        public ProfileController(
            IProfileAppService profileAppService, 
            ITimingAppService timingAppService)
        {
            _profileAppService = profileAppService;
            _timingAppService = timingAppService;
        }

        public async Task<PartialViewResult> MySettingsModal()
        {
            var output = await _profileAppService.GetCurrentUserProfileForEdit();
            var timezoneItems = await _timingAppService.GetTimezoneComboboxItems(new GetTimezoneComboboxItemsInput
            {
                DefaultTimezoneScope = SettingScopes.User,
                SelectedTimezoneId = output.Timezone
            });

            var viewModel = new MySettingsViewModel(output)
            {
                TimezoneItems = timezoneItems
            };

            return PartialView("_MySettingsModal", viewModel);
        }

        public PartialViewResult ChangePictureModal()
        {
            return PartialView("_ChangePictureModal");
        }

        public PartialViewResult ChangePasswordModal()
        {
            return PartialView("_ChangePasswordModal");
        }

        public PartialViewResult LinkedAccountsModal()
        {
            return PartialView("_LinkedAccountsModal");
        }

        public PartialViewResult LinkAccountModal()
        {
            return PartialView("_LinkAccountModal");
        }
    }
}