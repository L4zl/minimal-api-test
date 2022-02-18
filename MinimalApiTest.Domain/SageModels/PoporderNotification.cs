using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderNotification
    {
        public long PoporderNotificationId { get; set; }
        public long PoporderReturnId { get; set; }
        public long SysnotificationId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long PoporderNotificationTypeId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PoporderNotificationType PoporderNotificationType { get; set; } = null!;
        public virtual PoporderReturn PoporderReturn { get; set; } = null!;
        public virtual Sysnotification Sysnotification { get; set; } = null!;
    }
}
