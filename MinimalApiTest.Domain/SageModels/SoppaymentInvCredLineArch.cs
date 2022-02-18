using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoppaymentInvCredLineArch
    {
        public long SoppaymentInvCredLineId { get; set; }
        public long SoppaymentId { get; set; }
        public long SopinvoiceCreditLineId { get; set; }
        public long PaymentInvCredLineTypeId { get; set; }

        public virtual PaymentInvCredLineType PaymentInvCredLineType { get; set; } = null!;
        public virtual SopinvCreditLineArch SopinvoiceCreditLine { get; set; } = null!;
        public virtual SoppaymentArch Soppayment { get; set; } = null!;
    }
}
