using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Delta.SaleProject
{
    [DependsOn(typeof(SaleProjectXamarinSharedModule))]
    public class SaleProjectXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaleProjectXamarinIosModule).GetAssembly());
        }
    }
}