using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Delta.SaleProject.MultiTenancy.HostDashboard.Dto;

namespace Delta.SaleProject.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}