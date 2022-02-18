using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class OpOperationSubcontractQuantityBreak
    {
        public long OpOperationSubcontractQuantityBreakId { get; set; }
        public long OpOperationSubcontractSupplierId { get; set; }
        public decimal? QuantityFrom { get; set; }
        public decimal? QuantityTo { get; set; }
        public decimal Cost { get; set; }
        public int HoursOffsite { get; set; }
        public bool RatePerItem { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual OpOperationSubcontractSupplier OpOperationSubcontractSupplier { get; set; } = null!;
    }
}
