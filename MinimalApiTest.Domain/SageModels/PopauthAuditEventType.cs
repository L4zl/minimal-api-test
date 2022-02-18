using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopauthAuditEventType
    {
        public PopauthAuditEventType()
        {
            PopauthAuditEvents = new HashSet<PopauthAuditEvent>();
        }

        public long PopauthAuditEventTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PopauthAuditEvent> PopauthAuditEvents { get; set; }
    }
}
