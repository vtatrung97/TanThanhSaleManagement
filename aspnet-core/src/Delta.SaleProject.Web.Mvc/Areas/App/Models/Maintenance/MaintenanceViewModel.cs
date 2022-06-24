using System.Collections.Generic;
using Delta.SaleProject.Caching.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}