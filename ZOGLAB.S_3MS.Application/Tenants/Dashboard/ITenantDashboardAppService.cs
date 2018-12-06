using Abp.Application.Services;
using ZOGLAB.S_3MS.Tenants.Dashboard.Dto;

namespace ZOGLAB.S_3MS.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
