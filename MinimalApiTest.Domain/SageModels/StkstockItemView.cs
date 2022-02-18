using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkstockItemView
    {
        public long ItemId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal? SellingPrice { get; set; }
        public decimal? Price { get; set; }
        public decimal? ActualQuantity { get; set; }
        public long? BomitemTypeId { get; set; }
        public decimal FreeStockQuantity { get; set; }
        public bool? ThisIsTheStandardBand { get; set; }
        public string? Description { get; set; }
        public bool UseDescriptionOnDocs { get; set; }
        public decimal StandardCost { get; set; }
        public decimal SopitemPrice { get; set; }
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
        public DateTime? StdCostVarianceLastReset { get; set; }
        public decimal AverageBuyingPrice { get; set; }
        public bool SaleFromSingleBatch { get; set; }
        public bool AllowDuplicateNumbers { get; set; }
        public bool UsesAlternativeRef { get; set; }
        public bool UsesSellByDate { get; set; }
        public bool UsesUseByDate { get; set; }
        public bool RecordNosOnGoodsReceived { get; set; }
        public DateTime? LastArchivedUpTo { get; set; }
        public long SoporderFulfilmentMethodId { get; set; }
        public string DefaultDespatchNoteComment { get; set; } = null!;
        public string DefaultPickingListComment { get; set; } = null!;
        public decimal QuantityReserved { get; set; }
        public DateTime? LastTraceArchivedUpTo { get; set; }
        public decimal LandedCostsValue { get; set; }
        public bool AllowSalesOrder { get; set; }
        public long AutoGenerateOptionTypeId { get; set; }
        public string AutoGeneratePrefix { get; set; } = null!;
        public long AutoGenerateNextNumber { get; set; }
        public long LabelPrintingOptionTypeId { get; set; }
        public long FulfilmentSequenceTypeId { get; set; }
        public int ShelfLife { get; set; }
        public long? StockItemStatusId { get; set; }
        public long? ShelfLifeTypeId { get; set; }
        public bool AllowOutOfDate { get; set; }
        public string ProductGroupCode { get; set; } = null!;
        public string ProductGroupDescription { get; set; } = null!;
        public long TraceableTypeId { get; set; }
        public long StockItemTypeId { get; set; }
        public long CostingMethodId { get; set; }
        public bool DoItemsUseMarkup { get; set; }
        public decimal? ConfirmedQuantityInStock { get; set; }
        public decimal? UnconfirmedQuantityInStock { get; set; }
        public DateTime? DateOfLastSale { get; set; }
        public DateTime? DateOfLastStockCount { get; set; }
        public decimal? QuantityAllocatedSop { get; set; }
        public decimal? QuantityAllocatedStock { get; set; }
        public decimal? QuantityAllocatedBom { get; set; }
        public decimal? QuantityOnPoporder { get; set; }
        public decimal? ReorderLevel { get; set; }
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
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
    }
}
