using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlreportMessage
    {
        public long SlreportMessageId { get; set; }
        public long SlreportMessageTypeId { get; set; }
        public int MessageNumber { get; set; }
        public string Line1 { get; set; } = null!;
        public string Line2 { get; set; } = null!;
        public string Line3 { get; set; } = null!;
        public decimal MinimumCreditLimit { get; set; }
        public decimal MinimumBalance { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
