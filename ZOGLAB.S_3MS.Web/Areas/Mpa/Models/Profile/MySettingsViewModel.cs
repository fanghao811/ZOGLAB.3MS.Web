using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ZOGLAB.S_3MS.Authorization.Users;
using ZOGLAB.S_3MS.Authorization.Users.Profile.Dto;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Profile
{
    [AutoMapFrom(typeof (CurrentUserProfileEditDto))]
    public class MySettingsViewModel : CurrentUserProfileEditDto
    {
        public List<ComboboxItemDto> TimezoneItems { get; set; }

        public bool CanChangeUserName
        {
            get { return UserName != User.AdminUserName; }
        }

        public MySettingsViewModel(CurrentUserProfileEditDto currentUserProfileEditDto)
        {
            currentUserProfileEditDto.MapTo(this);
        }
    }
}