using Abp.Domain.Entities.Auditing;
using Delta.SaleProject.Employees;
using Delta.SaleProject.ExportStocks;
using Delta.SaleProject.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.ImportStocks
{
    [Table("ImportExportStocks")]
    public class ImportExportStock: FullAuditedEntity
    {
        public string SalesManName { get; set; }
        public string VehiclePlateNumber { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public ICollection<ExportStock> ExportStocks { get; set; }
        public ICollection<ImportStock> ImportStocks { get; set; }
    }
}
