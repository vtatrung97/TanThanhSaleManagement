using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Delta.SaleProject
{
    public class SaleProjectCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaleProjectCoreSharedModule).GetAssembly());
        }
    }
}