using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillEvent
    {
        public long BlbillEventId { get; set; }
        public long BleventId { get; set; }
        public long BlbillId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Blbill Blbill { get; set; } = null!;
        public virtual Blevent Blevent { get; set; } = null!;
    }
}
