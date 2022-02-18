using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoprcptRtnInvCredLine
    {
        public long PoprcptRtnInvCredLineId { get; set; }
        public long PopreceiptReturnLineId { get; set; }
        public long PopinvoiceCreditLineId { get; set; }
        public decimal InvoiceCreditQuantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long IntrastatStatusId { get; set; }
        public decimal StockUnitInvCredQuantity { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual IntrastatStatus IntrastatStatus { get; set; } = null!;
        public virtual PopinvoiceCreditLine PopinvoiceCreditLine { get; set; } = null!;
        public virtual PopreceiptReturnLine PopreceiptReturnLine { get; set; } = null!;
    }
}
