using System.Threading.Tasks;
using ZOGLAB.S_3MS.Sessions.Dto;

namespace ZOGLAB.S_3MS.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
