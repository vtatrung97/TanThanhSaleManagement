using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Delta.SaleProject.Authorization;

namespace Delta.SaleProject
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(SaleProjectApplicationSharedModule),
        typeof(SaleProjectCoreModule)
        )]
    public class SaleProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaleProjectApplicationModule).GetAssembly());
        }
    }
}