using System.Collections.Generic;
using Abp.Dependency;
using Abp.RealTime;

namespace ZOGLAB.S_3MS.Authorization.Users
{
    public interface IUserLogoutInformer
    {
        void InformClients(IReadOnlyList<IOnlineClient> clients);
    }
}
