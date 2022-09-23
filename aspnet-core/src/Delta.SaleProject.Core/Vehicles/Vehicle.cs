using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Vehicles
{
    [Table("Vehicles")]
    public class Vehicle : FullAuditedEntity, IMayHaveTenant
    {
        public string PlateNumber { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int ProductionYear { get; set; }
        public int? TenantId { get; set; }
    }
}
