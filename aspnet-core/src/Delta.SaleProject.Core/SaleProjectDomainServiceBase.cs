using Abp.Domain.Services;

namespace Delta.SaleProject
{
    public abstract class SaleProjectDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected SaleProjectDomainServiceBase()
        {
            LocalizationSourceName = SaleProjectConsts.LocalizationSourceName;
        }
    }
}
