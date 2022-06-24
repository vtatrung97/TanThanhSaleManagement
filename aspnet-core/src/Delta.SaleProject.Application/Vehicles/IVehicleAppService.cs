using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Delta.SaleProject.Vehicles.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Vehicles
{
    internal interface IVehicleAppService: IApplicationService
    {
        Task<ListResultDto<VehicleListDto>> GetAll(GetAllVehiclesInput input);
        Task<VehicleDto> Get(int id);
        Task Create(CreateVehicleInput input);
        Task Update(UpdateVehicleInputDto input);
        Task Delete(int id);
    }
}
