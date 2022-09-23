using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Products.Dtos
{
    public class CreateProductInput
    {
<<<<<<< HEAD
        public const int MaxNameLength = 250;

        [Required]
        [MaxLength(MaxNameLength)]
=======
>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Weight { get; set; }
        public bool IsGasTankSell { get; set; }
    }
}
