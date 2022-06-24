using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Delta.SaleProject.Vehicles.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Vehicles
{
    public class VehicleAppService : SaleProjectAppServiceBase, IVehicleAppService
    {
        private readonly IRepository<Vehicle> _repository;

        public VehicleAppService(IRepository<Vehicle> repository)
        {
            _repository = repository;
        }

        public async Task Create(CreateVehicleInput input)
        {
            try
            {
                Logger.Info("Inserting a vehicle for input: " + input);
                var task = ObjectMapper.Map<Vehicle>(input);
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
                Logger.Info("Deleting a vehicle for id: " + id);
                var exVehicle = await _repository.FirstOrDefaultAsync(id);
                if (exVehicle == null)
                {
                    throw new UserFriendlyException(L("CouldNotFindTheTaskMessage"));
                }
             
                await _repository.DeleteAsync(exVehicle);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw ex;
            }
        }

        public async Task<VehicleDto> Get(int id)
        {
            try
            {
                Logger.Info("Getting a vehicle with id: " + id);
                var exVehicle = await _repository.FirstOrDefaultAsync(id);
                if (exVehicle == null)
                {
                    throw new UserFriendlyException(L("CouldNotFindTheTaskMessage"));
                }

                return ObjectMapper.Map<VehicleDto>(exVehicle);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw ex;
            }
        }

        public async Task<ListResultDto<VehicleListDto>> GetAll(GetAllVehiclesInput input)
        {
            try
            {
                Logger.Info("Get all vehicles for input: " + input);
            var vehicles = await _repository.GetAll()
                .WhereIf(!string.IsNullOrEmpty(input.KeyWord), t => t.PlateNumber.Contains(input.KeyWord)).ToListAsync();
            return new ListResultDto<VehicleListDto>(ObjectMapper.Map<List<VehicleListDto>>(vehicles));
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw ex;
            }
        }

        public async Task Update(UpdateVehicleInputDto input)
        {
            try
            {
                var vehicle = ObjectMapper.Map<Vehicle>(input);
                await _repository.UpdateAsync(vehicle);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw ex;
            }
        }
    }
}
