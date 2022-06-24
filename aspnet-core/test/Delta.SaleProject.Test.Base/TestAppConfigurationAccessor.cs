using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Delta.SaleProject.Configuration;

namespace Delta.SaleProject.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(SaleProjectTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
