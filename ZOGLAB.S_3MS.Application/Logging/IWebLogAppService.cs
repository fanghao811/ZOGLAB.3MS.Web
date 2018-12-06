using Abp.Application.Services;
using ZOGLAB.S_3MS.Dto;
using ZOGLAB.S_3MS.Logging.Dto;

namespace ZOGLAB.S_3MS.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
