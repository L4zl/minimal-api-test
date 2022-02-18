using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderNotificationView
    {
        public long PoporderNotificationId { get; set; }
        public long PoporderReturnId { get; set; }
        public long SysnotificationId { get; set; }
        public long PoporderNotificationTypeId { get; set; }
        public long SysnotificationPriorityTypeId { get; set; }
        public long SysnotificationStatusTypeId { get; set; }
        public string SubjectText { get; set; } = null!;
        public string BodyText { get; set; } = null!;
        public long UserFromId { get; set; }
        public string UserFromName { get; set; } = null!;
        public DateTime TimeAndDateNotifCreated { get; set; }
        public DateTime? DueDate { get; set; }
        public bool NotificationSent { get; set; }
    }
}
