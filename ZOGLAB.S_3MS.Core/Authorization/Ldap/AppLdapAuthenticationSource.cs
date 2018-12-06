using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using ZOGLAB.S_3MS.Authorization.Users;
using ZOGLAB.S_3MS.MultiTenancy;

namespace ZOGLAB.S_3MS.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
