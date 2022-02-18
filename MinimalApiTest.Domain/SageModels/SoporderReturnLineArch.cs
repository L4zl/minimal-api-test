using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderReturnLineArch
    {
        public SoporderReturnLineArch()
        {
            SopinvCreditLineArches = new HashSet<SopinvCreditLineArch>();
            SopstandardItemLinkArches = new HashSet<SopstandardItemLinkArch>();
        }

        public long SoporderReturnLineId { get; set; }
        public long SoporderReturnId { get; set; }
        public short PrintSequenceNumber { get; set; }
        public long LineTypeId { get; set; }
        public string ItemCode { get; set; } = null!;
        public bool UseDescription { get; set; }
        public decimal LineQuantity { get; set; }
        public decimal LineTotalValue { get; set; }
        public decimal LineTaxValue { get; set; }
        public decimal UnitSellingPrice { get; set; }
        public bool UnitSellPriceOverridden { get; set; }
        public decimal UnitDiscountPercent { get; set; }
        public decimal UnitDiscountValue { get; set; }
        public bool DiscountPercentSpecified { get; set; }
        public bool UnitDiscountOverridden { get; set; }
        public decimal SellingUnitMultiple { get; set; }
        public decimal PricingUnitMultiple { get; set; }
        public long? TaxCodeId { get; set; }
        public string NominalAccountRef { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public DateTime? RequestedDeliveryDate { get; set; }
        public DateTime? PromisedDeliveryDate { get; set; }
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public bool? ShowOnCustomerDocs { get; set; }
        public bool ApplyOrderValueDiscount { get; set; }
        public decimal AllocatedQuantity { get; set; }
        public bool RepeatOrderPricesFixed { get; set; }
        public decimal DespatchReceiptQuantity { get; set; }
        public decimal InvoiceCreditQuantity { get; set; }
        public string PricingUnitDescription { get; set; } = null!;
        public string SellingUnitDescription { get; set; } = null!;
        public long PoporderReturnLineId { get; set; }
        public long BackToBackStatusId { get; set; }
        public bool AdditionalChargeInvoiced { get; set; }
        public bool IsLocked { get; set; }
        public decimal AvailableForDespatch { get; set; }
        public bool ReadyForInvoicePrint { get; set; }
        public decimal PostedInvoiceCreditQty { get; set; }
        public long StockItemTypeId { get; set; }
        public decimal TraceAvailForDespatch { get; set; }
        public decimal CostPrice { get; set; }
        public bool BomdetailsOnDespatchNote { get; set; }
        public long? TemmessageId { get; set; }
        public short? TemmessageLineNo { get; set; }
        public decimal SellingUnitWeight { get; set; }
        public bool ShowOnDespatchNote { get; set; }
        public long TraceableTypeId { get; set; }
        public long ConfirmationIntentTypeId { get; set; }
        public string DespatchNoteComment { get; set; } = null!;
        public string PickingListComment { get; set; } = null!;
        public long ShowOnPickingListTypeId { get; set; }
        public long SoporderFulfilmentMethodId { get; set; }
        public decimal QuantityReserved { get; set; }
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
        public bool? IncludeInMrp { get; set; }
        public decimal LineUnitPrecision { get; set; }
        public decimal StockUnitPrecision { get; set; }
        public decimal StockUnitLineQuantity { get; set; }
        public decimal StockUnitAllocatedQuantity { get; set; }
        public decimal StockUnitDespRcptQuantity { get; set; }
        public decimal StockUnitInvoiceCreditQuantity { get; set; }
        public decimal StockUnitPostedInvCredQty { get; set; }
        public decimal StockUnitAvailableForDespatch { get; set; }
        public decimal StockUnitMultiple { get; set; }
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

        public virtual ConfirmationIntentType ConfirmationIntentType { get; set; } = null!;
        public virtual OrderReturnLineType LineType { get; set; } = null!;
        public virtual ShowOnPickingListType ShowOnPickingListType { get; set; } = null!;
        public virtual SoporderFulfilmentMethod SoporderFulfilmentMethod { get; set; } = null!;
        public virtual SoporderReturnArch SoporderReturn { get; set; } = null!;
        public virtual StockItemType StockItemType { get; set; } = null!;
        public virtual SystaxRate? TaxCode { get; set; }
        public virtual TraceableType TraceableType { get; set; } = null!;
        public virtual ICollection<SopinvCreditLineArch> SopinvCreditLineArches { get; set; }
        public virtual ICollection<SopstandardItemLinkArch> SopstandardItemLinkArches { get; set; }
    }
}
