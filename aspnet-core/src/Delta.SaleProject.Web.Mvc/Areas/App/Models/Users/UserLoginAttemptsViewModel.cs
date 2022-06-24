using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Users
{
    public class UserLoginAttemptsViewModel
    {
        public List<ComboboxItemDto> LoginAttemptResults { get; set; }
    }
}