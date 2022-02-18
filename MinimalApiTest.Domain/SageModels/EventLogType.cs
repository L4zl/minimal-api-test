using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class EventLogType
    {
        public EventLogType()
        {
            EventLogs = new HashSet<EventLog>();
        }

        public long EventLogTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<EventLog> EventLogs { get; set; }
    }
}
