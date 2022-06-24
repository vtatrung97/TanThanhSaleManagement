﻿using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Delta.SaleProject.Configuration;

namespace Delta.SaleProject.Test.Base.Configuration
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
