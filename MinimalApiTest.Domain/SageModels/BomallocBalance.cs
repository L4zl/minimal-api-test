using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomallocBalance
    {
        public long BomallocBalanceId { get; set; }
        public long BomallocComponentId { get; set; }
        public long AllocationBalanceId { get; set; }
        public decimal Quantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomallocComponent BomallocComponent { get; set; } = null!;
    }
}
