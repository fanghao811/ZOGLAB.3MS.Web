using System.ComponentModel.DataAnnotations;
using Abp.Notifications;

namespace ZOGLAB.S_3MS.Notifications.Dto
{
    public class NotificationSubscriptionDto
    {
        [Required]
        [MaxLength(NotificationInfo.MaxNotificationNameLength)]
        public string Name { get; set; }

        public bool IsSubscribed { get; set; }
    }
}