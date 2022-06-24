using Abp.Domain.Entities.Auditing;
using Delta.SaleProject.ImportStocks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Employees
{
    [Table("Employees")]
    public class Employee: FullAuditedEntity
    {
        public virtual string FullName { get; set; }
        public virtual DateTime DateBirth { get; set; }
        public virtual string IdentityNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual string PhoneNumber { get; set; }
        public ICollection<ImportExportStock> ImportExportStocks { get; set; }
    }
}
