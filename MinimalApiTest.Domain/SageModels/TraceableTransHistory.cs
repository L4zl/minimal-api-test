using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceableTransHistory
    {
        public long TraceableTransHistoryId { get; set; }
        public long TransactionHistoryId { get; set; }
        public long TraceableTransTypeId { get; set; }
        public long TraceableItemId { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public string? AdditionalReference { get; set; }
        public DateTime? SellByDate { get; set; }
        public DateTime? UseByDate { get; set; }
        public decimal Quantity { get; set; }
        public long TraceableItemStatusId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TraceableItemStatus TraceableItemStatus { get; set; } = null!;
        public virtual TraceableTransType TraceableTransType { get; set; } = null!;
        public virtual TransactionHistory TransactionHistory { get; set; } = null!;
    }
}
