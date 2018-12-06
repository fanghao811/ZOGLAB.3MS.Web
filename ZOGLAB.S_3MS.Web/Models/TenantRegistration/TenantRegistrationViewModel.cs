using System.ComponentModel.DataAnnotations;
using ZOGLAB.S_3MS.Authorization.Users;
using ZOGLAB.S_3MS.MultiTenancy;

namespace ZOGLAB.S_3MS.Web.Models.TenantRegistration
{
    public class TenantRegistrationViewModel
    {
        [Required]
        [StringLength(Tenant.MaxTenancyNameLength)]
        public string TenancyName { get; set; }

        [Required]
        [StringLength(User.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(User.MaxEmailAddressLength)]
        public string AdminEmailAddress { get; set; }

        [StringLength(User.MaxPlainPasswordLength)]
        public string AdminPassword { get; set; }
    }
}