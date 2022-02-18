using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlallocationTran
    {
        public long SlallocationTranId { get; set; }
        public long SlallocationHeaderId { get; set; }
        public long SlpostedCustomerTranId { get; set; }
        public decimal AllocationValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlallocationHeader SlallocationHeader { get; set; } = null!;
        public virtual SlpostedCustomerTran SlpostedCustomerTran { get; set; } = null!;
    }
}
