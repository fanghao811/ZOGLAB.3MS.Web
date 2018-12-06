using Abp.Notifications;
using ZOGLAB.S_3MS.Dto;

namespace ZOGLAB.S_3MS.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}