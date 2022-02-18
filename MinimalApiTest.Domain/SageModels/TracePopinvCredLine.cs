using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TracePopinvCredLine
    {
        public long TracePopinvCredLineId { get; set; }
        public long PopInvoiceCreditLineId { get; set; }
        public long TraceableBinItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal InvoicedCreditedQuantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopinvoiceCreditLine PopInvoiceCreditLine { get; set; } = null!;
        public virtual TraceableBinItem TraceableBinItem { get; set; } = null!;
    }
}
