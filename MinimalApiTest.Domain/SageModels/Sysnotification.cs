using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Sysnotification
    {
        public Sysnotification()
        {
            PoporderNotifications = new HashSet<PoporderNotification>();
            SysnotificationUsers = new HashSet<SysnotificationUser>();
        }

        public long SysnotificationId { get; set; }
        public long SysnotificationPriorityTypeId { get; set; }
        public long SysnotificationStatusTypeId { get; set; }
        public string SubjectText { get; set; } = null!;
        public string BodyText { get; set; } = null!;
        public long UserFromId { get; set; }
        public string UserFromName { get; set; } = null!;
        public DateTime TimeAndDateNotifCreated { get; set; }
        public DateTime? DueDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool NotificationSent { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysnotificationPriorityType SysnotificationPriorityType { get; set; } = null!;
        public virtual SysnotificationStatusType SysnotificationStatusType { get; set; } = null!;
        public virtual ICollection<PoporderNotification> PoporderNotifications { get; set; }
        public virtual ICollection<SysnotificationUser> SysnotificationUsers { get; set; }
    }
}
