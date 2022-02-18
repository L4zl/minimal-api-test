using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderReturnArch
    {
        public SoporderReturnArch()
        {
            SopcancelledLineArches = new HashSet<SopcancelledLineArch>();
            SopinvCreditLineArches = new HashSet<SopinvCreditLineArch>();
            SoporderReturnLineArches = new HashSet<SoporderReturnLineArch>();
            SoppaymentArches = new HashSet<SoppaymentArch>();
        }

        public long SoporderReturnId { get; set; }
        public long DocumentTypeId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public long DocumentStatusId { get; set; }
        public long DocumentPrintStatusId { get; set; }
        public string CustomerDocumentNo { get; set; } = null!;
        public long CustomerId { get; set; }
        public long CustomerTypeId { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public DateTime? PromisedDeliveryDate { get; set; }
        public long? WarehouseId { get; set; }
        public long? CurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal SubtotalGoodsValue { get; set; }
        public decimal SubtotalChargesNetValue { get; set; }
        public decimal SubtotalChargesTaxValue { get; set; }
        public decimal SubtotalDiscountValue { get; set; }
        public decimal TotalNetValue { get; set; }
        public decimal TotalTaxValue { get; set; }
        public decimal TotalGrossValue { get; set; }
        public bool UseInvoiceAddress { get; set; }
        public bool PaymentWithOrder { get; set; }
        public long PaymentTypeId { get; set; }
        public decimal PaymentValue { get; set; }
        public string PaymentReference { get; set; } = null!;
        public long? PaymentBankAccountId { get; set; }
        public string? PaymentNominalAccountRef { get; set; }
        public string? PaymentNominalCostCentre { get; set; }
        public string? PaymentNominalDepartment { get; set; }
        public long? PaymentNominalCodeId { get; set; }
        public bool PaymentInvoiced { get; set; }
        public decimal SettlementDiscPercent { get; set; }
        public short SettlementDiscountDays { get; set; }
        public decimal DocumentDiscountPercent { get; set; }
        public string DocumentCreatedBy { get; set; } = null!;
        public string Priority { get; set; } = null!;
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public short IntrastatStatus { get; set; }
        public long SourceTypeId { get; set; }
        public string SourceDocumentNo { get; set; } = null!;
        public bool ArePricesTaxInclusive { get; set; }
        public bool ReadyForInvoicePrint { get; set; }
        public DateTime? DocumentDueDate { get; set; }
        public long? PaymentMethodId { get; set; }
        public bool BomdetailsOnDespatchNote { get; set; }
        public string? PaymentMethodName { get; set; }
        public decimal TotalGrossValueIncSett { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string SpareText1 { get; set; } = null!;
        public string SpareText2 { get; set; } = null!;
        public string SpareText3 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public string ExternalReference { get; set; } = null!;
        public bool InvoicePaymentImmediately { get; set; }
        public string? Crmreference { get; set; }
        public long? Crmaccount { get; set; }
        public string AnalysisCode7 { get; set; } = null!;
        public string AnalysisCode8 { get; set; } = null!;
        public string AnalysisCode9 { get; set; } = null!;
        public string AnalysisCode10 { get; set; } = null!;
        public string AnalysisCode11 { get; set; } = null!;
        public string AnalysisCode12 { get; set; } = null!;
        public string AnalysisCode13 { get; set; } = null!;
        public string AnalysisCode14 { get; set; } = null!;
        public string AnalysisCode15 { get; set; } = null!;
        public string AnalysisCode16 { get; set; } = null!;
        public string AnalysisCode17 { get; set; } = null!;
        public string AnalysisCode18 { get; set; } = null!;
        public string AnalysisCode19 { get; set; } = null!;
        public string AnalysisCode20 { get; set; } = null!;
        public bool TriangularTransaction { get; set; }
        public decimal EsvatDiscountAmount { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public bool ReadyForAllocation { get; set; }
        public long AllocatedStatusId { get; set; }
        public bool ReadyForDespatchReceipt { get; set; }
        public long DespatchReceiptStatusId { get; set; }
        public long InvoiceCreditStatusId { get; set; }
        public long CancelledStatusId { get; set; }
        public bool IsCis { get; set; }

        public virtual DocumentProcessStatus AllocatedStatus { get; set; } = null!;
        public virtual DocumentProcessStatus CancelledStatus { get; set; } = null!;
        public virtual Syscurrency? Currency { get; set; }
        public virtual SlcustomerAccount Customer { get; set; } = null!;
        public virtual CustomerType CustomerType { get; set; } = null!;
        public virtual DocumentProcessStatus DespatchReceiptStatus { get; set; } = null!;
        public virtual DocumentPrintStatus DocumentStatus { get; set; } = null!;
        public virtual DocumentStatus DocumentStatusNavigation { get; set; } = null!;
        public virtual SoporderReturnType DocumentType { get; set; } = null!;
        public virtual DocumentProcessStatus InvoiceCreditStatus { get; set; } = null!;
        public virtual Cbaccount? PaymentBankAccount { get; set; }
        public virtual SoppaymentMethod? PaymentMethod { get; set; }
        public virtual NlnominalAccount? PaymentNominalCode { get; set; }
        public virtual PaymentType PaymentType { get; set; } = null!;
        public virtual SoporderReturnType SourceType { get; set; } = null!;
        public virtual Warehouse? Warehouse { get; set; }
        public virtual CashAcctInvAddressArch CashAcctInvAddressArch { get; set; } = null!;
        public virtual SopdocDelAddressArch SopdocDelAddressArch { get; set; } = null!;
        public virtual ICollection<SopcancelledLineArch> SopcancelledLineArches { get; set; }
        public virtual ICollection<SopinvCreditLineArch> SopinvCreditLineArches { get; set; }
        public virtual ICollection<SoporderReturnLineArch> SoporderReturnLineArches { get; set; }
        public virtual ICollection<SoppaymentArch> SoppaymentArches { get; set; }
    }
}
