using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCispaymentAudit
    {
        public long SiconCispaymentAuditId { get; set; }
        public long? SiconCissupplierId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierReference { get; set; }
        public long? PaymentUrn { get; set; }
        public string? PaymentReference { get; set; }
        public long? CreditNoteUrn { get; set; }
        public string? CreditNoteReference { get; set; }
        public long? InvoiceUrn { get; set; }
        public string? InvoiceReference { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? SessionInvValue { get; set; }
        public decimal? SessionInvAllocated { get; set; }
        public decimal? SessionInvExcludeCisamt { get; set; }
        public decimal? SessionInvPaymentValue { get; set; }
        public decimal? SessionInvPaymentAllocated { get; set; }
        public decimal? SessionCostOfMaterialsPercent { get; set; }
        public decimal? SessionCisvalue { get; set; }
        public decimal? SessionCisallocated { get; set; }
        public decimal? InvTotalOutstandingPrePay { get; set; }
        public decimal? InvTotalOutstandingPostPay { get; set; }
        public decimal? CisoutstandingPrePay { get; set; }
        public decimal? CisoutstandingPostPay { get; set; }
        public decimal? TaxRate { get; set; }
        public DateTime? SiconCisreturnPeriodEnd { get; set; }
        public bool? Cisuploaded { get; set; }
        public DateTime? CisuploadedDate { get; set; }
        public string? CisuploadedByUserId { get; set; }
        public long? SiconCisreturnId { get; set; }
        public decimal? PaymentValue { get; set; }
        public decimal? TaxValue { get; set; }
        public decimal? LabourValue { get; set; }
        public decimal? MaterialsValue { get; set; }
        public decimal? OtherValue { get; set; }
        public decimal? PaymentAllocationRatio { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? DeductionUrn { get; set; }
        public decimal? Cisrate { get; set; }
        public bool? Submitted { get; set; }
    }
}
