using Abp;

namespace Delta.SaleProject
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="SaleProjectDomainServiceBase"/>.
    /// For application services inherit SaleProjectAppServiceBase.
    /// </summary>
    public abstract class SaleProjectServiceBase : AbpServiceBase
    {
        protected SaleProjectServiceBase()
        {
            LocalizationSourceName = SaleProjectConsts.LocalizationSourceName;
        }
    }
}