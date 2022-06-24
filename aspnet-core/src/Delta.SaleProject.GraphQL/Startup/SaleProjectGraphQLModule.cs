using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Delta.SaleProject.Startup
{
    [DependsOn(typeof(SaleProjectCoreModule))]
    public class SaleProjectGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaleProjectGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}