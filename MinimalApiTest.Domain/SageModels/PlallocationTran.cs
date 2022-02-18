using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlallocationTran
    {
        public long PlallocationTranId { get; set; }
        public long PlallocationHeaderId { get; set; }
        public long PlpostedSupplierTranId { get; set; }
        public decimal AllocationValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlallocationHeader PlallocationHeader { get; set; } = null!;
        public virtual PlpostedSupplierTran PlpostedSupplierTran { get; set; } = null!;
    }
}
