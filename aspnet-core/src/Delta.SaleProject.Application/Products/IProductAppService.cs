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
<<<<<<< HEAD
    public interface IProductAppService : IApplicationService
    {
        Task<ListResultDto<ProductDto>> GetAll(GetAllProductsInput input);
        Task<ProductDto> Get(int id);
        Task Create(CreateProductInput input);
        Task Update(ProductDto input);
=======
    internal interface IProductAppService:IApplicationService
    {
        Task<ListResultDto<ProductListDto>> GetAll(GetAllProductsInput input);
        Task<ProductDto> Get(int id);
        Task Create(CreateProductInput input);
        Task Update(UpdateProductInputDto input);
>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
        Task Delete(int id);
    }
}
