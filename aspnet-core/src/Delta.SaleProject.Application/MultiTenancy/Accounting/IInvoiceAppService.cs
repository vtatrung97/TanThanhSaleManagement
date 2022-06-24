using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Delta.SaleProject.MultiTenancy.Accounting.Dto;

namespace Delta.SaleProject.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
