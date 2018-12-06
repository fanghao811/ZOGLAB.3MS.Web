using System.Threading.Tasks;
using Abp.Configuration;

namespace ZOGLAB.S_3MS.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
