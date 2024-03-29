﻿using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Delta.SaleProject.Products.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Products
{
    public class ProductAppService : SaleProjectAppServiceBase, IProductAppService
    {
        private readonly IRepository<Product> _repository;
<<<<<<< HEAD
=======

>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
        public ProductAppService(IRepository<Product> repository)
        {
            _repository = repository;
        }
<<<<<<< HEAD
=======

>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
        public async Task Create(CreateProductInput input)
        {
            try
            {
                Logger.Info("Inserting a product for input: " + input);
                var task = ObjectMapper.Map<Product>(input);
                await _repository.InsertAsync(task);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw ex;
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                Logger.Info("Deleting a product for id: " + id);
                var exProduct = await _repository.FirstOrDefaultAsync(id);
                if (exProduct == null)
                {
                    throw new UserFriendlyException(L("CouldNotFindTheTaskMessage"));
                }

                await _repository.DeleteAsync(exProduct);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw ex;
            }
        }

        public async Task<ProductDto> Get(int id)
        {
            try
            {
                Logger.Info("Getting a product with id: " + id);
<<<<<<< HEAD
                var exVehicle = await _repository.FirstOrDefaultAsync(id);
                if (exVehicle == null)
=======
                var exProduct = await _repository.FirstOrDefaultAsync(id);
                if (exProduct == null)
>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
                {
                    throw new UserFriendlyException(L("CouldNotFindTheTaskMessage"));
                }

<<<<<<< HEAD
                return ObjectMapper.Map<ProductDto>(exVehicle);
=======
                return ObjectMapper.Map<ProductDto>(exProduct);
>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw ex;
            }
        }

<<<<<<< HEAD
        public async Task<ListResultDto<ProductDto>> GetAll(GetAllProductsInput input)
=======
        public async Task<ListResultDto<ProductListDto>> GetAll(GetAllProductsInput input)
>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
        {
            try
            {
                Logger.Info("Get all products for input: " + input);
                var products = await _repository.GetAll()
<<<<<<< HEAD
                    .WhereIf(!string.IsNullOrEmpty(input.KeyWord), t => t.Description.Contains(input.KeyWord)).ToListAsync();
                return new ListResultDto<ProductDto>(ObjectMapper.Map<List<ProductDto>>(products));
=======
                    .WhereIf(!string.IsNullOrEmpty(input.KeyWord), t => t.Name.Contains(input.KeyWord)).ToListAsync();
                return new ListResultDto<ProductListDto>(ObjectMapper.Map<List<ProductListDto>>(products));
>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw ex;
            }
        }

<<<<<<< HEAD
        public async Task Update(ProductDto input)
=======
        public async Task Update(UpdateProductInputDto input)
>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
        {
            try
            {
                var product = ObjectMapper.Map<Product>(input);
                await _repository.UpdateAsync(product);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw ex;
            }
        }
    }
}
