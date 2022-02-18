using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceableAllocationBal
    {
        public long TraceableAllocationBalId { get; set; }
        public long TraceableBinItemId { get; set; }
        public long? AllocationBalanceId { get; set; }
        public decimal AllocatedQuantity { get; set; }
        public decimal DespatchedQuantity { get; set; }
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual AllocationBalance? AllocationBalance { get; set; }
        public virtual TraceableBinItem TraceableBinItem { get; set; } = null!;
    }
}
