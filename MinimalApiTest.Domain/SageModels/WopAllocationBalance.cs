using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopAllocationBalance
    {
        public long WopAllocationBalanceId { get; set; }
        public long? WopAllocationLineId { get; set; }
        public long AllocationBalanceId { get; set; }
        public decimal AllocationQuantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopAllocationLine? WopAllocationLine { get; set; }
    }
}
