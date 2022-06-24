using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Delta.SaleProject.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Products
{
    internal interface IProductAppService:IApplicationService
    {
        Task<ListResultDto<ProductListDto>> GetAll(GetAllProductsInput input);
        Task<ProductDto> Get(int id);
        Task Create(CreateProductInput input);
        Task Update(UpdateProductInputDto input);
        Task Delete(int id);
    }
}
