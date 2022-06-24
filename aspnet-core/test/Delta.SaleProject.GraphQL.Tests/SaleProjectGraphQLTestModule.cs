using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Delta.SaleProject.Configure;
using Delta.SaleProject.Startup;
using Delta.SaleProject.Test.Base;

namespace Delta.SaleProject.GraphQL.Tests
{
    [DependsOn(
        typeof(SaleProjectGraphQLModule),
        typeof(SaleProjectTestBaseModule))]
    public class SaleProjectGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaleProjectGraphQLTestModule).GetAssembly());
        }
    }
}