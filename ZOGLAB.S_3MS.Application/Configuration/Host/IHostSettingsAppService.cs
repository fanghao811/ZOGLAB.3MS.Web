using System.Threading.Tasks;
using Abp.Application.Services;
using ZOGLAB.S_3MS.Configuration.Host.Dto;

namespace ZOGLAB.S_3MS.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
