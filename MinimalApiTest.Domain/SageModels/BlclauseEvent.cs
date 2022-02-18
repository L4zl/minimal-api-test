using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlclauseEvent
    {
        public long BlclauseEventId { get; set; }
        public long BlclauseId { get; set; }
        public long BleventId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Blclause Blclause { get; set; } = null!;
        public virtual Blevent Blevent { get; set; } = null!;
    }
}
