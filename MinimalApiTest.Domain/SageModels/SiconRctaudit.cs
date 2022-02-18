using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRctaudit
    {
        public long SiconRctauditId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? SiconCissupplierId { get; set; }
        public DateTime? PostedDate { get; set; }
        public long? OriginalTranId { get; set; }
        public DateTime? OriginalTranDate { get; set; }
        public long? OriginalTranUrn { get; set; }
        public string? Reference { get; set; }
        public string? Reference2 { get; set; }
        public decimal? Labour { get; set; }
        public decimal? Materials { get; set; }
        public decimal? Other { get; set; }
        public decimal? Rct { get; set; }
        public decimal? Rctrate { get; set; }
        public string? RctrateDescription { get; set; }
        public decimal? Tax { get; set; }
        public string? LinkedJobs { get; set; }
        public string LinkedTransactions { get; set; } = null!;
        public long? DeductionTransactionId { get; set; }
        public long? DeductionTransactionUrn { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public decimal? OriginalPaymentValue { get; set; }
        public decimal? ActualPaymentValue { get; set; }
        public long? PaymentReceiptPostedId { get; set; }
        public long? PlproposedPaymentPostedTranId { get; set; }
        public string? ContractNotificationId { get; set; }
        public string? PaymentNotificationId { get; set; }
        public string? AcknowledgementNumber { get; set; }
    }
}
