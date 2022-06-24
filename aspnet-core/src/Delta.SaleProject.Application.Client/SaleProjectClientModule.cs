using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Delta.SaleProject
{
    public class SaleProjectClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaleProjectClientModule).GetAssembly());
        }
    }
}
