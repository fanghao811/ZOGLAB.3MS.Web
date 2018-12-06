using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using ZOGLAB.S_3MS.Authorization.Users;

namespace ZOGLAB.S_3MS.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}