using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class EventLog
    {
        public long EventLogId { get; set; }
        public DateTime DateOfEvent { get; set; }
        public DateTime TimeOfEvent { get; set; }
        public long EventLogTypeId { get; set; }
        public string Source { get; set; } = null!;
        public string Area { get; set; } = null!;
        public string Description { get; set; } = null!;
        public short Code { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual EventLogType EventLogType { get; set; } = null!;
    }
}
