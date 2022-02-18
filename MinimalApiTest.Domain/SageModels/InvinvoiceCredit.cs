using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InvinvoiceCredit
    {
        public InvinvoiceCredit()
        {
            InvinvCredNominalItems = new HashSet<InvinvCredNominalItem>();
            InvinvCredTaxItems = new HashSet<InvinvCredTaxItem>();
            InvinvoiceCreditLines = new HashSet<InvinvoiceCreditLine>();
        }

        public long InvinvoiceCreditId { get; set; }
        public long InvbillingAddressId { get; set; }
        public DateTime DocumentDate { get; set; }
        public string SecondReference { get; set; } = null!;
        public long InvdeliveryAddressId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public long DocumentStatusId { get; set; }
        public decimal InvoicedChargesValue { get; set; }
        public decimal DiscountedTotalGoods { get; set; }
        public decimal InvoicedDiscountValue { get; set; }
        public decimal InvoicedGrossValue { get; set; }
        public decimal InvdGrossValInclSettDisc { get; set; }
        public decimal InvoicedNetValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal DocumentDiscountValue { get; set; }
        public decimal DocumentDiscountPercent { get; set; }
        public decimal SettlementDiscPercent { get; set; }
        public bool TaxOnlyDocument { get; set; }
        public decimal ToBaseCurrencyRate { get; set; }
        public decimal InvoicedCoreTaxValue { get; set; }
        public long InvinvoiceCreditTypeId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public DateTime? DateCancelled { get; set; }
        public string? CancelledBy { get; set; }
        public bool ArePricesTaxInclusive { get; set; }
        public short SettlementDiscountDays { get; set; }
        public decimal InvoicedTaxValue { get; set; }
        public string ReasonCancelled { get; set; } = null!;
        public decimal EsvatDiscountAmount { get; set; }
        public decimal InvdNetValInclSettDisc { get; set; }
        public decimal InvdTaxValInclSettDisc { get; set; }
        public decimal InvdCoreTaxValInclSettDisc { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string PaymentCloudPaymentId { get; set; } = null!;
        public string EmailHeader { get; set; } = null!;
        public long InvoiceCreditUpdateStatusTypeId { get; set; }
        public long PaymentCloudPaymentStatusTypeId { get; set; }
        public bool IsCis { get; set; }
        public decimal InvoicedTaxValInclNotional { get; set; }
        public decimal InvoicedCoreTaxValInclNotional { get; set; }

        public virtual InvinvoiceStatus DocumentStatus { get; set; } = null!;
        public virtual InvinvoiceCreditAddress InvbillingAddress { get; set; } = null!;
        public virtual InvinvoiceCreditAddress InvdeliveryAddress { get; set; } = null!;
        public virtual InvinvoiceCreditType InvinvoiceCreditType { get; set; } = null!;
        public virtual InvoiceCreditUpdateStatusType InvoiceCreditUpdateStatusType { get; set; } = null!;
        public virtual PaymentCloudPaymentStatusType PaymentCloudPaymentStatusType { get; set; } = null!;
        public virtual SlcustomerAccount? SlcustomerAccount { get; set; }
        public virtual ICollection<InvinvCredNominalItem> InvinvCredNominalItems { get; set; }
        public virtual ICollection<InvinvCredTaxItem> InvinvCredTaxItems { get; set; }
        public virtual ICollection<InvinvoiceCreditLine> InvinvoiceCreditLines { get; set; }
    }
}
