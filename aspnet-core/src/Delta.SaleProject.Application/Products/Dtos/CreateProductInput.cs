using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Products.Dtos
{
    public class CreateProductInput
    {
        public const int MaxNameLength = 250;

        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Weight { get; set; }
        public bool IsGasTankSell { get; set; }
    }
}
