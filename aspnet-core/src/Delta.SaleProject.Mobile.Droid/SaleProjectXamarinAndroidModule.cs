using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Delta.SaleProject
{
    [DependsOn(typeof(SaleProjectXamarinSharedModule))]
    public class SaleProjectXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaleProjectXamarinAndroidModule).GetAssembly());
        }
    }
}