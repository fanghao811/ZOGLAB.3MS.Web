using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace ZOGLAB.S_3MS.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
