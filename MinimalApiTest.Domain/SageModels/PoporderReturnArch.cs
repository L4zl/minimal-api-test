using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderReturnArch
    {
        public PoporderReturnArch()
        {
            PopcancelledLineArches = new HashSet<PopcancelledLineArch>();
            PoporderReturnLineArches = new HashSet<PoporderReturnLineArch>();
        }

        public long PoporderReturnId { get; set; }
        public long DocumentTypeId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public long DocumentStatusId { get; set; }
        public long DocumentPrintStatusId { get; set; }
        public string SupplierDocumentNo { get; set; } = null!;
        public long? SupplierId { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public long? WarehouseId { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal SubtotalGoodsValue { get; set; }
        public decimal SubtotalChargesNetValue { get; set; }
        public decimal SubtotalChargesTaxValue { get; set; }
        public decimal SubtotalDiscountValue { get; set; }
        public decimal TotalNetValue { get; set; }
        public decimal TotalTaxValue { get; set; }
        public decimal TotalGrossValue { get; set; }
        public decimal TotalAccrualValue { get; set; }
        public decimal SettlementDiscPercent { get; set; }
        public short SettlementDiscountDays { get; set; }
        public decimal DocumentDiscountPercent { get; set; }
        public string DocumentCreatedBy { get; set; } = null!;
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public short IntrastatStatus { get; set; }
        public long SourceTypeId { get; set; }
        public string SourceDocumentNo { get; set; } = null!;
        public long AuthorisationStatusId { get; set; }
        public bool SingleDeliveryAddress { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal SubtotalLandedCosts { get; set; }
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
        public long? DefaultDeliveryAddressId { get; set; }
        public long? Crmaccount { get; set; }
        public long? DocumentCreatedByUserId { get; set; }
        public string DocumentOriginatorName { get; set; } = null!;
        public long? DocumentOriginatorId { get; set; }
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
        public decimal EsvatDiscountAmount { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual AuthorisationStatus AuthorisationStatus { get; set; } = null!;
        public virtual PopordReturnLineDelAddrArch? DefaultDeliveryAddress { get; set; }
        public virtual DocumentPrintStatus DocumentPrintStatus { get; set; } = null!;
        public virtual DocumentStatus DocumentStatus { get; set; } = null!;
        public virtual PoporderReturnType DocumentType { get; set; } = null!;
        public virtual PoporderReturnType SourceType { get; set; } = null!;
        public virtual PlsupplierAccount? Supplier { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual PopdocDelAddressArch PopdocDelAddressArch { get; set; } = null!;
        public virtual ICollection<PopcancelledLineArch> PopcancelledLineArches { get; set; }
        public virtual ICollection<PoporderReturnLineArch> PoporderReturnLineArches { get; set; }
    }
}
