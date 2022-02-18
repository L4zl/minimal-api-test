using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopTraceableIssue
    {
        public long WopTraceableIssueId { get; set; }
        public long WopIssueId { get; set; }
        public decimal Quantity { get; set; }
        public long TraceableItemId { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal? ReversedQuantity { get; set; }
        public long TraceableBinItemId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopIssue WopIssue { get; set; } = null!;
    }
}
