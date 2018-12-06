using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ZOGLAB.S_3MS.Authorization.Users;

namespace ZOGLAB.S_3MS.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string ProfilePictureId { get; set; }
    }
}
