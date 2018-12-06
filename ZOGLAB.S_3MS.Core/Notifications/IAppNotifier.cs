using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using ZOGLAB.S_3MS.Authorization.Users;
using ZOGLAB.S_3MS.MultiTenancy;

namespace ZOGLAB.S_3MS.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
