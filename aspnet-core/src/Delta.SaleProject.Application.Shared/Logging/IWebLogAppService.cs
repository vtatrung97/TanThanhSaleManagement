using Abp.Application.Services;
using Delta.SaleProject.Dto;
using Delta.SaleProject.Logging.Dto;

namespace Delta.SaleProject.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
