﻿using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Delta.SaleProject.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
