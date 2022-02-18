using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SldocumentMessage
    {
        public long SldocumentMessageId { get; set; }
        public long SldocumentMessageUsedForId { get; set; }
        public string Description { get; set; } = null!;
        public short MessageNumber { get; set; }
        public string MessageLine1 { get; set; } = null!;
        public string MessageLine2 { get; set; } = null!;
        public string MessageLine3 { get; set; } = null!;
        public string MessageLine4 { get; set; } = null!;
        public decimal OmitIfAccountBalanceLessThan { get; set; }
        public decimal OmitIfCreditLimitGreaterThan { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SldocumentMessageUsedFor SldocumentMessageUsedFor { get; set; } = null!;
    }
}
