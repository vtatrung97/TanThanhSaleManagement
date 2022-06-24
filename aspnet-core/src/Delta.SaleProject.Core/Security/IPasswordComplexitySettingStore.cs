using System.Threading.Tasks;

namespace Delta.SaleProject.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
