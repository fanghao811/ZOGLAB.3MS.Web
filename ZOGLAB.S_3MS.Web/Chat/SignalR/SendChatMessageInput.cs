using System;

namespace ZOGLAB.S_3MS.Web.Chat.SignalR
{
    public class SendChatMessageInput
    {
        public int? TenantId { get; set; }

        public long UserId { get; set; }

        public string UserName { get; set; }

        public string TenancyName { get; set; }

        public Guid? ProfilePictureId { get; set; }

        public string Message { get; set; }
    }
}