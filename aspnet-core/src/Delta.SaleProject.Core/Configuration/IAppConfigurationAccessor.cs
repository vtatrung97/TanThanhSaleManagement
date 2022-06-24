using Microsoft.Extensions.Configuration;

namespace Delta.SaleProject.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
