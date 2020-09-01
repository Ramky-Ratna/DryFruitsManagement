using System;
using System.Collections.Generic;

namespace DryFruiltsDataService.Models
{
    public partial class TblNotifications
    {
        public int NotificationsId { get; set; }
        public string NotificationsName { get; set; }
        public string NotificationsQualification { get; set; }
        public int? NotificationsAgeLimit { get; set; }
        public DateTime? NotificationsStartDate { get; set; }
        public DateTime? NotificationsLastDate { get; set; }
        public string NotificationsSalary { get; set; }
        public string NotificationsSite { get; set; }
        public DateTime? NotificationsCreated { get; set; }
        public DateTime? NotificationsUpdated { get; set; }
    }
}
