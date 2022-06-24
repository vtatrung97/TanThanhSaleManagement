using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Delta.SaleProject.Editions.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}