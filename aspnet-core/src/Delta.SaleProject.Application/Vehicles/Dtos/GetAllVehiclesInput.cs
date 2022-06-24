using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Vehicles.Dtos
{
    public class GetAllVehiclesInput
    {
        public string KeyWord { get; set; }
    }

    [AutoMapFrom(typeof(Vehicle))]
    public class VehicleListDto : EntityDto, IHasCreationTime
    {
        public string PlateNumber { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int ProductionYear { get; set; }
    }

   
}
