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
    [AutoMapFrom(typeof(Vehicle))]
    public class VehicleDto : EntityDto, IHasCreationTime
    {
        public string PlateNumber { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int ProductionYear { get; set; }
        public int TenantId { get; set; }
    }
    [AutoMapTo(typeof(Vehicle))]
    public class UpdateVehicleInputDto : EntityDto, IHasCreationTime
    {
        public string PlateNumber { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int ProductionYear { get; set; }
        public int TenantId { get; set; }
    }
}
