using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillLineInvoiceCreditLine
    {
        public long BlbillLineInvoiceCreditLineId { get; set; }
        public long BlbillLineId { get; set; }
        public long InvinvoiceCreditLineId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BlbillLine BlbillLine { get; set; } = null!;
        public virtual InvinvoiceCreditLine InvinvoiceCreditLine { get; set; } = null!;
    }
}
