using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItem
    {
        public StockItem()
        {
            AlternativeItemItemAlternatives = new HashSet<AlternativeItem>();
            AlternativeItemItems = new HashSet<AlternativeItem>();
            BinItems = new HashSet<BinItem>();
            PcanalysisFieldValues = new HashSet<PcanalysisFieldValue>();
            PopstandardItemLinkArches = new HashSet<PopstandardItemLinkArch>();
            PopstandardItemLinks = new HashSet<PopstandardItemLink>();
            PoptoReorderItems = new HashSet<PoptoReorderItem>();
            SiconKitLines = new HashSet<SiconKitLine>();
            SiconKitTemplateLines = new HashSet<SiconKitTemplateLine>();
            SiconKitTemplates = new HashSet<SiconKitTemplate>();
            SiconKits = new HashSet<SiconKit>();
            SoppreReceiptAllocs = new HashSet<SoppreReceiptAlloc>();
            SoppreferredItems = new HashSet<SoppreferredItem>();
            SopstandardItemLinkArches = new HashSet<SopstandardItemLinkArch>();
            SopstandardItemLinks = new HashSet<SopstandardItemLink>();
            StandardCostVariances = new HashSet<StandardCostVariance>();
            StockItemAverageCostHistories = new HashSet<StockItemAverageCostHistory>();
            StockItemCrossSellItemItemCrossSellItems = new HashSet<StockItemCrossSellItem>();
            StockItemCrossSellItemItems = new HashSet<StockItemCrossSellItem>();
            StockItemDiscounts = new HashSet<StockItemDiscount>();
            StockItemMemos = new HashSet<StockItemMemo>();
            StockItemNominalCodes = new HashSet<StockItemNominalCode>();
            StockItemPeriodBalances = new HashSet<StockItemPeriodBalance>();
            StockItemPrices = new HashSet<StockItemPrice>();
            StockItemSearchCatVals = new HashSet<StockItemSearchCatVal>();
            StockItemStandardCostHistories = new HashSet<StockItemStandardCostHistory>();
            StockItemSuppliers = new HashSet<StockItemSupplier>();
            StockItemUnitUomtypes = new HashSet<StockItemUnitUomtype>();
            StockItemUnits = new HashSet<StockItemUnit>();
            StockPreReceiptAllocs = new HashSet<StockPreReceiptAlloc>();
            StockRevalueAuditTrails = new HashSet<StockRevalueAuditTrail>();
            TemcustProdMappings = new HashSet<TemcustProdMapping>();
            TemsuppProdMappings = new HashSet<TemsuppProdMapping>();
            TraceableItemArches = new HashSet<TraceableItemArch>();
            TraceableItems = new HashSet<TraceableItem>();
            TransactionArchives = new HashSet<TransactionArchive>();
            TransactionHistories = new HashSet<TransactionHistory>();
            WarehouseItems = new HashSet<WarehouseItem>();
        }

        public long ItemId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public long ProductGroupId { get; set; }
        public bool UseDescriptionOnDocs { get; set; }
        public long TaxCodeId { get; set; }
        public decimal StandardCost { get; set; }
        public decimal SopitemPrice { get; set; }
        public long? StockItemStatusId { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string Manufacturer { get; set; } = null!;
        public string PartNumber { get; set; } = null!;
        public short StocktakeCyclePeriod { get; set; }
        public string CommodityCode { get; set; } = null!;
        public decimal Weight { get; set; }
        public bool SuppressNetMass { get; set; }
        public string StockUnitName { get; set; } = null!;
        public string BaseUnitName { get; set; } = null!;
        public decimal StockMultOfBaseUnit { get; set; }
        public string? Barcode { get; set; }
        public DateTime? StdCostVarianceLastReset { get; set; }
        public decimal AverageBuyingPrice { get; set; }
        public long TraceableTypeId { get; set; }
        public bool SaleFromSingleBatch { get; set; }
        public bool AllowDuplicateNumbers { get; set; }
        public bool UsesAlternativeRef { get; set; }
        public bool UsesSellByDate { get; set; }
        public bool UsesUseByDate { get; set; }
        public bool RecordNosOnGoodsReceived { get; set; }
        public DateTime? LastArchivedUpTo { get; set; }
        public decimal FreeStockQuantity { get; set; }
        public long? BomitemTypeId { get; set; }
        public long SoporderFulfilmentMethodId { get; set; }
        public string DefaultDespatchNoteComment { get; set; } = null!;
        public string DefaultPickingListComment { get; set; } = null!;
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime? LastTraceArchivedUpTo { get; set; }
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
        public bool? AllowSalesOrder { get; set; }
        public long StkautoGenerateOptionTypeId { get; set; }
        public string AutoGeneratePrefix { get; set; } = null!;
        public long AutoGenerateNextNumber { get; set; }
        public long StklabelPrintingOptionTypeId { get; set; }
        public long StkfulfilmentSequenceTypeId { get; set; }
        public int ShelfLife { get; set; }
        public long? StkshelfLifeTypeId { get; set; }
        public bool AllowOutOfDate { get; set; }
        public long StkautoGenerateSeparatorId { get; set; }
        public int AutoGeneratePadding { get; set; }
        public long? CountryOfOriginId { get; set; }
        public bool UsesSupplementaryUnit { get; set; }
        public decimal SupplementaryUnitConversionRatio { get; set; }
        public bool UsesRcv { get; set; }
        public bool IsWeeeitem { get; set; }
        public bool? IncludeNosOnCountSheets { get; set; }
        public string Description { get; set; } = null!;
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
        public string AnalysisCode6 { get; set; } = null!;
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

        public virtual BomitemType? BomitemType { get; set; }
        public virtual SyscountryCode? CountryOfOrigin { get; set; }
        public virtual LandedCostsType LandedCostsType { get; set; } = null!;
        public virtual ProductGroup ProductGroup { get; set; } = null!;
        public virtual SoporderFulfilmentMethod SoporderFulfilmentMethod { get; set; } = null!;
        public virtual StkautoGenerateOptionType StkautoGenerateOptionType { get; set; } = null!;
        public virtual StkautoGenerateSeparator StkautoGenerateSeparator { get; set; } = null!;
        public virtual StkfulfilmentSequenceType StkfulfilmentSequenceType { get; set; } = null!;
        public virtual StklabelPrintingOptionType StklabelPrintingOptionType { get; set; } = null!;
        public virtual StkshelfLifeType? StkshelfLifeType { get; set; }
        public virtual StockItemStatus? StockItemStatus { get; set; }
        public virtual SystaxRate TaxCode { get; set; } = null!;
        public virtual TraceableType TraceableType { get; set; } = null!;
        public virtual ICollection<AlternativeItem> AlternativeItemItemAlternatives { get; set; }
        public virtual ICollection<AlternativeItem> AlternativeItemItems { get; set; }
        public virtual ICollection<BinItem> BinItems { get; set; }
        public virtual ICollection<PcanalysisFieldValue> PcanalysisFieldValues { get; set; }
        public virtual ICollection<PopstandardItemLinkArch> PopstandardItemLinkArches { get; set; }
        public virtual ICollection<PopstandardItemLink> PopstandardItemLinks { get; set; }
        public virtual ICollection<PoptoReorderItem> PoptoReorderItems { get; set; }
        public virtual ICollection<SiconKitLine> SiconKitLines { get; set; }
        public virtual ICollection<SiconKitTemplateLine> SiconKitTemplateLines { get; set; }
        public virtual ICollection<SiconKitTemplate> SiconKitTemplates { get; set; }
        public virtual ICollection<SiconKit> SiconKits { get; set; }
        public virtual ICollection<SoppreReceiptAlloc> SoppreReceiptAllocs { get; set; }
        public virtual ICollection<SoppreferredItem> SoppreferredItems { get; set; }
        public virtual ICollection<SopstandardItemLinkArch> SopstandardItemLinkArches { get; set; }
        public virtual ICollection<SopstandardItemLink> SopstandardItemLinks { get; set; }
        public virtual ICollection<StandardCostVariance> StandardCostVariances { get; set; }
        public virtual ICollection<StockItemAverageCostHistory> StockItemAverageCostHistories { get; set; }
        public virtual ICollection<StockItemCrossSellItem> StockItemCrossSellItemItemCrossSellItems { get; set; }
        public virtual ICollection<StockItemCrossSellItem> StockItemCrossSellItemItems { get; set; }
        public virtual ICollection<StockItemDiscount> StockItemDiscounts { get; set; }
        public virtual ICollection<StockItemMemo> StockItemMemos { get; set; }
        public virtual ICollection<StockItemNominalCode> StockItemNominalCodes { get; set; }
        public virtual ICollection<StockItemPeriodBalance> StockItemPeriodBalances { get; set; }
        public virtual ICollection<StockItemPrice> StockItemPrices { get; set; }
        public virtual ICollection<StockItemSearchCatVal> StockItemSearchCatVals { get; set; }
        public virtual ICollection<StockItemStandardCostHistory> StockItemStandardCostHistories { get; set; }
        public virtual ICollection<StockItemSupplier> StockItemSuppliers { get; set; }
        public virtual ICollection<StockItemUnitUomtype> StockItemUnitUomtypes { get; set; }
        public virtual ICollection<StockItemUnit> StockItemUnits { get; set; }
        public virtual ICollection<StockPreReceiptAlloc> StockPreReceiptAllocs { get; set; }
        public virtual ICollection<StockRevalueAuditTrail> StockRevalueAuditTrails { get; set; }
        public virtual ICollection<TemcustProdMapping> TemcustProdMappings { get; set; }
        public virtual ICollection<TemsuppProdMapping> TemsuppProdMappings { get; set; }
        public virtual ICollection<TraceableItemArch> TraceableItemArches { get; set; }
        public virtual ICollection<TraceableItem> TraceableItems { get; set; }
        public virtual ICollection<TransactionArchive> TransactionArchives { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
        public virtual ICollection<WarehouseItem> WarehouseItems { get; set; }
    }
}
