using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopinvoiceCredit
    {
        public SopinvoiceCredit()
        {
            InvoiceProfitAnalyses = new HashSet<InvoiceProfitAnalysis>();
            SopinvCredNominalItems = new HashSet<SopinvCredNominalItem>();
            SopinvCredTaxItems = new HashSet<SopinvCredTaxItem>();
            SopinvoiceCreditLines = new HashSet<SopinvoiceCreditLine>();
        }

        public long SopinvoiceCreditId { get; set; }
        public long SopinvoiceCreditTypeId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public long DocumentStatusId { get; set; }
        public long CustomerId { get; set; }
        public string SecondReference { get; set; } = null!;
        public DateTime DocumentDate { get; set; }
        public bool IsConsolidated { get; set; }
        public bool ArePricesTaxInclusive { get; set; }
        public decimal DocumentDiscountPercent { get; set; }
        public decimal DocumentDiscountValue { get; set; }
        public short SettlementDiscountDays { get; set; }
        public decimal SettlementDiscPercent { get; set; }
        public decimal InvoicedChargesValue { get; set; }
        public decimal DiscountedTotalGoods { get; set; }
        public string FullPaymentText { get; set; } = null!;
        public bool PaymentWithOrder { get; set; }
        public long PaymentTypeId { get; set; }
        public decimal PaymentValue { get; set; }
        public string PaymentReference { get; set; } = null!;
        public long? PaymentBankAccountId { get; set; }
        public string PaymentNominalAccountRef { get; set; } = null!;
        public string PaymentNominalCostCentre { get; set; } = null!;
        public string PaymentNominalDepartment { get; set; } = null!;
        public decimal InvoicedNetValue { get; set; }
        public decimal InvoicedDiscountValue { get; set; }
        public decimal InvoicedTaxValue { get; set; }
        public decimal InvoicedCoreTaxValue { get; set; }
        public decimal InvoicedGrossValue { get; set; }
        public decimal InvdGrossValInclSettDisc { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime? DateCancelled { get; set; }
        public string? ReasonCancelled { get; set; }
        public string? CancelledBy { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal InvoicedTaxValInclNotional { get; set; }
        public decimal InvoicedCoreTaxValInclNotional { get; set; }
        public long Source { get; set; }
        public bool TriangularTransaction { get; set; }
        public decimal EsvatDiscountAmount { get; set; }
        public decimal InvdNetValInclSettDisc { get; set; }
        public decimal InvdTaxValInclSettDisc { get; set; }
        public decimal InvdCoreTaxValInclSettDisc { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string CustomerDocumentNo { get; set; } = null!;
        public long? SoporderReturnId { get; set; }
        public string PaymentCloudPaymentId { get; set; } = null!;
        public string EmailHeader { get; set; } = null!;
        public long InvoiceCreditUpdateStatusTypeId { get; set; }
        public long PaymentCloudPaymentStatusTypeId { get; set; }
        public bool IsCis { get; set; }

        public virtual SlcustomerAccount Customer { get; set; } = null!;
        public virtual DocumentStatus DocumentStatus { get; set; } = null!;
        public virtual InvoiceCreditUpdateStatusType InvoiceCreditUpdateStatusType { get; set; } = null!;
        public virtual Cbaccount? PaymentBankAccount { get; set; }
        public virtual PaymentCloudPaymentStatusType PaymentCloudPaymentStatusType { get; set; } = null!;
        public virtual PaymentType PaymentType { get; set; } = null!;
        public virtual SopinvoiceCreditType SopinvoiceCreditType { get; set; } = null!;
        public virtual SoporderReturn? SoporderReturn { get; set; }
        public virtual SopinvCredAddress SopinvCredAddress { get; set; } = null!;
        public virtual SopinvCredDelAddress SopinvCredDelAddress { get; set; } = null!;
        public virtual ICollection<InvoiceProfitAnalysis> InvoiceProfitAnalyses { get; set; }
        public virtual ICollection<SopinvCredNominalItem> SopinvCredNominalItems { get; set; }
        public virtual ICollection<SopinvCredTaxItem> SopinvCredTaxItems { get; set; }
        public virtual ICollection<SopinvoiceCreditLine> SopinvoiceCreditLines { get; set; }
    }
}
