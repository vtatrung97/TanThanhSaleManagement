using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Delta.SaleProject
{
    [DependsOn(typeof(SaleProjectClientModule), typeof(AbpAutoMapperModule))]
    public class SaleProjectXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaleProjectXamarinSharedModule).GetAssembly());
        }
    }
}