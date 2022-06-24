using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Products.Dtos
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : EntityDto
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Weight { get; set; }
        public bool IsGasTankSell { get; set; }
    }

    [AutoMapTo(typeof(Product))]
    public class UpdateProductInputDto : EntityDto
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Weight { get; set; }
        public bool IsGasTankSell { get; set; }
    }
}
