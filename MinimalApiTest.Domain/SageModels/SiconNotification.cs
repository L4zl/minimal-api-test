using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconNotification
    {
        public long SiconNotificationId { get; set; }
        public long? SiconSubscriptionId { get; set; }
        public string NotificationMessage { get; set; } = null!;
        public string NotificationModule { get; set; } = null!;
        public string NotificationEntityType { get; set; } = null!;
        public long NotificationEntityId { get; set; }
        public long? SiconEmployeeId { get; set; }
        public short NotificationPriorityId { get; set; }
        public long? SiconActivityFeedItemId { get; set; }
        public bool Dismissed { get; set; }
        public bool Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
