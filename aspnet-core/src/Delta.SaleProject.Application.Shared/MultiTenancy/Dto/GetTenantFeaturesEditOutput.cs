﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Delta.SaleProject.Editions.Dto;

namespace Delta.SaleProject.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}