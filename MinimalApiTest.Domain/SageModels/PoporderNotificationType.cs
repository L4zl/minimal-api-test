using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderNotificationType
    {
        public PoporderNotificationType()
        {
            PoporderNotifications = new HashSet<PoporderNotification>();
        }

        public long PoporderNotificationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoporderNotification> PoporderNotifications { get; set; }
    }
}
