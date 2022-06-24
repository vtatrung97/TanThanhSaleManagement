using System.Threading.Tasks;
using Abp.Application.Services;
using Delta.SaleProject.Install.Dto;

namespace Delta.SaleProject.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}