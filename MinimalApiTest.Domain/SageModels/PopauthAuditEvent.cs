using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopauthAuditEvent
    {
        public long PopauthAuditEventId { get; set; }
        public long PopauthAuditEventTypeId { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; } = null!;
        public long? SourceId { get; set; }
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeNotificationCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopauthAuditEventType PopauthAuditEventType { get; set; } = null!;
    }
}
