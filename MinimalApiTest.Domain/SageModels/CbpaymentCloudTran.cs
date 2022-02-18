using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbpaymentCloudTran
    {
        public long CbpaymentCloudTranId { get; set; }
        public string PaymentId { get; set; } = null!;
        public string PaymentSubmissionId { get; set; } = null!;
        public string ServiceProviderAccountKey { get; set; } = null!;
        public string ServiceProviderName { get; set; } = null!;
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public decimal NetAmount { get; set; }
        public decimal Fee { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public decimal ConversionRate { get; set; }
        public DateTime SubmissionDate { get; set; }
        public long CbpaymentCloudTranStatusTypeId { get; set; }
        public long CbpaymentCloudTranTypeId { get; set; }
        public string RelatedPaymentSubmissionId { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CbpaymentCloudTranStatusType CbpaymentCloudTranStatusType { get; set; } = null!;
        public virtual CbpaymentCloudTranType CbpaymentCloudTranType { get; set; } = null!;
    }
}
