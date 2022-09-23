<<<<<<< HEAD
﻿using System;
=======
﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Products.Dtos
{
    public class GetAllProductsInput
    {
        public string KeyWord { get; set; }
    }
<<<<<<< HEAD
=======

    [AutoMapFrom(typeof(Product))]
    public class ProductListDto : EntityDto
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Weight { get; set; }
        public bool IsGasTankSell { get; set; }
    }


>>>>>>> 3fae4b2902ff5906ba3d0861f3b76d3c21c1bad1
}
