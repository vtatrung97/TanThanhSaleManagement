using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.ProductCategories
{
    [Table("ProductCategories")]
    public class ProductCategory: FullAuditedEntity
    {
        public const int MaxNameLength = 250;
        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
