using Abp.Domain.Entities.Auditing;
using Delta.SaleProject.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.ImportStocks
{
    [Table("ImportStocks")]
    public class ImportStock: FullAuditedEntity
    {
        public virtual int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalWeight { get; set; }
        public virtual int ImportExportStockId { get; set; }
        public ImportExportStock ImportExportStock { get; set; }
    }
}
