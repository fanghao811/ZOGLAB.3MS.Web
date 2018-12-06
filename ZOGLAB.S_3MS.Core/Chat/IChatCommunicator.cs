using System.Collections.Generic;
using Abp;
using Abp.RealTime;
using ZOGLAB.S_3MS.Friendships;

namespace ZOGLAB.S_3MS.Chat
{
    public interface IChatCommunicator
    {
        void SendMessageToClient(IReadOnlyList<IOnlineClient> clients, ChatMessage message);

        void SendFriendshipRequestToClient(IReadOnlyList<IOnlineClient> clients, Friendship friend, bool isOwnRequest, bool isFriendOnline);

        void SendUserConnectionChangeToClients(IReadOnlyList<IOnlineClient> clients, UserIdentifier user, bool isConnected);

        void SendUserStateChangeToClients(IReadOnlyList<IOnlineClient> clients, UserIdentifier user, FriendshipState newState);

        void SendAllUnreadMessagesOfUserReadToClients(IReadOnlyList<IOnlineClient> clients, UserIdentifier user);
    }
}
