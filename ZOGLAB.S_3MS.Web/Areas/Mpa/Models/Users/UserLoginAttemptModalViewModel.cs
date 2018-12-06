using System.Collections.Generic;
using ZOGLAB.S_3MS.Authorization.Users.Dto;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}