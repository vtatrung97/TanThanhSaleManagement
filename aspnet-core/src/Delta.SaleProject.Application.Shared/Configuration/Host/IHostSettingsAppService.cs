﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Delta.SaleProject.Configuration.Host.Dto;

namespace Delta.SaleProject.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
