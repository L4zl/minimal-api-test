using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlproposedPaymentPostedTran
    {
        public long PlproposedPaymentPostedTranId { get; set; }
        public long PlpostedSupplierTranId { get; set; }
        public long PlproposedPaymentId { get; set; }
        public decimal DiscountToClaimValue { get; set; }
        public decimal ToPayValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlpostedSupplierTran PlpostedSupplierTran { get; set; } = null!;
        public virtual PlproposedPayment PlproposedPayment { get; set; } = null!;
    }
}
