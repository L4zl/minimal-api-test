using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlremittanceMessage
    {
        public long PlremittanceMessageId { get; set; }
        public string Description { get; set; } = null!;
        public short MessageNumber { get; set; }
        public string Line1 { get; set; } = null!;
        public string Line2 { get; set; } = null!;
        public string Line3 { get; set; } = null!;
        public string Line4 { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
