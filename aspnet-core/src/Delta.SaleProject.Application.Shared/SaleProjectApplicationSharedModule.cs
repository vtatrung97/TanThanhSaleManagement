using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Delta.SaleProject
{
    [DependsOn(typeof(SaleProjectCoreSharedModule))]
    public class SaleProjectApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaleProjectApplicationSharedModule).GetAssembly());
        }
    }
}