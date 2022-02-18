using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderReturnLine
    {
        public PoporderReturnLine()
        {
            PopinvoiceCreditLines = new HashSet<PopinvoiceCreditLine>();
            PoponOrderLines = new HashSet<PoponOrderLine>();
            PopreceiptReturnLines = new HashSet<PopreceiptReturnLine>();
            RequestedDeliveryDates = new HashSet<RequestedDeliveryDate>();
            SoporderReturnLines = new HashSet<SoporderReturnLine>();
        }

        public long PoporderReturnLineId { get; set; }
        public long PoporderReturnId { get; set; }
        public short PrintSequenceNumber { get; set; }
        public long LineTypeId { get; set; }
        public string ItemCode { get; set; } = null!;
        public bool UseDescription { get; set; }
        public string SupplierPartRef { get; set; } = null!;
        public decimal LineQuantity { get; set; }
        public decimal LineTotalValue { get; set; }
        public decimal LineTaxValue { get; set; }
        public decimal UnitBuyingPrice { get; set; }
        public decimal UnitDiscountPercent { get; set; }
        public decimal UnitDiscountValue { get; set; }
        public bool DiscountPercentSpecified { get; set; }
        public decimal BuyingUnitMultiple { get; set; }
        public decimal PricingUnitMultiple { get; set; }
        public long? TaxCodeId { get; set; }
        public string NominalAccountRef { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public bool? ShowOnSupplierDocs { get; set; }
        public bool ApplyOrderValueDiscount { get; set; }
        public decimal OnOrderQuantity { get; set; }
        public decimal ReceiptReturnQuantity { get; set; }
        public decimal InvoiceCreditQuantity { get; set; }
        public decimal DisputedInvCredQty { get; set; }
        public string PricingUnitDescription { get; set; } = null!;
        public string BuyingUnitDescription { get; set; } = null!;
        public bool LinkedToSalesOrderLines { get; set; }
        public decimal AddChargeInvoiceValue { get; set; }
        public decimal DisputedAddChargeValue { get; set; }
        public bool IncorrectGrnmatching { get; set; }
        public short DeliverToGroup { get; set; }
        public bool IsLocked { get; set; }
        public bool ForReceiptReturn { get; set; }
        public long StockItemTypeId { get; set; }
        public long TraceableTypeId { get; set; }
        public bool DeliveryDirectFromSupplier { get; set; }
        public long? PopordReturnLineDelAddressId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool UpdatePricesAtGoodsReceipt { get; set; }
        public long LandedCostsTypeId { get; set; }
        public decimal LandedCostsValue { get; set; }
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
        public decimal LineUnitPrecision { get; set; }
        public decimal StockUnitPrecision { get; set; }
        public decimal StockUnitLineQuantity { get; set; }
        public decimal StockUnitOnOrderQuantity { get; set; }
        public decimal StockUnitRcptRtnQuantity { get; set; }
        public decimal StockUnitInvCredQuantity { get; set; }
        public decimal StockUnitDisputedInvCredQty { get; set; }
        public decimal StockUnitMultiple { get; set; }
        public long ConfirmationIntentTypeId { get; set; }
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
        public string ItemDescription { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
        public long? WarehouseId { get; set; }

        public virtual ConfirmationIntentType ConfirmationIntentType { get; set; } = null!;
        public virtual LandedCostsType LandedCostsType { get; set; } = null!;
        public virtual OrderReturnLineType LineType { get; set; } = null!;
        public virtual PopordReturnLineDelAddress? PopordReturnLineDelAddress { get; set; }
        public virtual PoporderReturn PoporderReturn { get; set; } = null!;
        public virtual StockItemType StockItemType { get; set; } = null!;
        public virtual SystaxRate? TaxCode { get; set; }
        public virtual TraceableType TraceableType { get; set; } = null!;
        public virtual Warehouse? Warehouse { get; set; }
        public virtual PopstandardItemLink PopstandardItemLink { get; set; } = null!;
        public virtual ICollection<PopinvoiceCreditLine> PopinvoiceCreditLines { get; set; }
        public virtual ICollection<PoponOrderLine> PoponOrderLines { get; set; }
        public virtual ICollection<PopreceiptReturnLine> PopreceiptReturnLines { get; set; }
        public virtual ICollection<RequestedDeliveryDate> RequestedDeliveryDates { get; set; }
        public virtual ICollection<SoporderReturnLine> SoporderReturnLines { get; set; }
    }
}
