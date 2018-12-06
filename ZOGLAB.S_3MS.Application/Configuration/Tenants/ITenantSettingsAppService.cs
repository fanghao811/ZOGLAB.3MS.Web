using System.Threading.Tasks;
using Abp.Application.Services;
using ZOGLAB.S_3MS.Configuration.Tenants.Dto;

namespace ZOGLAB.S_3MS.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
