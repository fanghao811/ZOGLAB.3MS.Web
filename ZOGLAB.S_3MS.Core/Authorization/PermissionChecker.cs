using Abp.Authorization;
using ZOGLAB.S_3MS.Authorization.Roles;
using ZOGLAB.S_3MS.Authorization.Users;
using ZOGLAB.S_3MS.MultiTenancy;

namespace ZOGLAB.S_3MS.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
