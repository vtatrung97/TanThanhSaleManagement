using System;
using Abp.Notifications;
using Delta.SaleProject.Dto;

namespace Delta.SaleProject.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}