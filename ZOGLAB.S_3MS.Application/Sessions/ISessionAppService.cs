using System.Threading.Tasks;
using Abp.Application.Services;
using ZOGLAB.S_3MS.Sessions.Dto;

namespace ZOGLAB.S_3MS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
