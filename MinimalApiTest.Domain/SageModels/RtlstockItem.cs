using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstockItem
    {
        public long PrdHierNodeId { get; set; }
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public string? StockUnit { get; set; }
        public string? TaxRate { get; set; }
        public string? Manufacturer { get; set; }
        public string? PartNo { get; set; }
        public string? CostMethod { get; set; }
        public decimal AverageBuyingPrice { get; set; }
        public string? BomDetails { get; set; }
        public bool UseItemDescription { get; set; }
        public string? ItemDescription { get; set; }
        public string? CommodityCode { get; set; }
        public decimal? Weight { get; set; }
        public bool SuppressMass { get; set; }
        public int? StockTakeDays { get; set; }
        public string? Memos { get; set; }
        public string? NomStockAcRef { get; set; }
        public string? NomStockCc { get; set; }
        public string? NomStockDept { get; set; }
        public string? NomRevenueAcRef { get; set; }
        public string? NomRevenueCc { get; set; }
        public string? NomRevenueDept { get; set; }
        public string? NomAccruedAcRef { get; set; }
        public string? NomAccruedCc { get; set; }
        public string? NomAccruedDept { get; set; }
        public string? NomIssuesAcRef { get; set; }
        public string? NomIssuesCc { get; set; }
        public string? NomIssuesDept { get; set; }
        public long LandedCostsTypeId { get; set; }
        public decimal LandedCostsValue { get; set; }
        public long? StockItemStatusId { get; set; }
        public DateTime? InactiveDate { get; set; }
        public decimal StandardCost { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long RtlstockItemId { get; set; }
        public long StklabelPrintingOptionTypeId { get; set; }
        public bool? AllowSalesOrder { get; set; }
        public long TraceableTypeId { get; set; }
        public bool SaleFromSingleBatch { get; set; }
        public bool AllowDuplicateNumbers { get; set; }
        public bool UsesAlternativeRef { get; set; }
        public bool UsesSellByDate { get; set; }
        public bool UsesUseByDate { get; set; }
        public bool RecordNosOnGoodsReceived { get; set; }
        public long StkautoGenerateOptionTypeId { get; set; }
        public string AutoGeneratePrefix { get; set; } = null!;
        public long AutoGenerateNextNumber { get; set; }
        public int AutoGeneratePadding { get; set; }
        public long StkautoGenerateSeperatorId { get; set; }
        public int ShelfLife { get; set; }
        public long? StkshelfLifeTypeId { get; set; }
        public bool AllowOutOfDate { get; set; }
        public long? CountryOfOriginId { get; set; }
        public decimal StockMultOfBaseUnit { get; set; }
        public decimal SupplementaryUnitConversionRatio { get; set; }
        public bool UsesRcv { get; set; }
        public bool UsesSupplementaryUnit { get; set; }
        public bool IsWeeeitem { get; set; }
        public string BaseUnitName { get; set; } = null!;
        public string DefaultPickingListComment { get; set; } = null!;
        public string DefaultDespatchNoteComment { get; set; } = null!;
        public bool IncludeNosOnCountSheets { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
