using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TracePoprcptRtnLine
    {
        public long TracePoprcptRtnLineId { get; set; }
        public long PopreceiptReturnLineId { get; set; }
        public long TraceableBinItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal InvoicedCreditedQuantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopreceiptReturnLine PopreceiptReturnLine { get; set; } = null!;
        public virtual TraceableBinItem TraceableBinItem { get; set; } = null!;
    }
}
