using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkworkspaceStockItem
    {
        public decimal QuantityInStock { get; set; }
        public decimal QuantityAllocated { get; set; }
        public decimal QuantityOnPoporder { get; set; }
        public decimal SalesPrice { get; set; }
        public long ItemId { get; set; }
        public long ProductGroupId { get; set; }
        public string ProductGroupCode { get; set; } = null!;
        public string ProductGroupName { get; set; } = null!;
        public string StockItemType { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? StockItemStatusName { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string StockUnitName { get; set; } = null!;
        public string? TaxRate { get; set; }
        public string CostingMethod { get; set; } = null!;
        public decimal StandardCost { get; set; }
        public decimal AverageBuyingPrice { get; set; }
        public decimal FreeStockQuantity { get; set; }
        public decimal QtySoldThisPeriod { get; set; }
        public decimal ValSoldThisPeriod { get; set; }
        public decimal QtySoldLastPeriod { get; set; }
        public decimal ValSoldLastPeriod { get; set; }
        public decimal QtyBoughtThisPeriod { get; set; }
        public decimal ValBoughtThisPeriod { get; set; }
        public decimal QtyBoughtLastPeriod { get; set; }
        public decimal ValBoughtLastPeriod { get; set; }
        public string TraceableType { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public string PartNumber { get; set; } = null!;
        public string? Bomdetails { get; set; }
        public string LabelPrintingOption { get; set; } = null!;
        public bool AllowSalesOrder { get; set; }
        public string CommodityCode { get; set; } = null!;
        public decimal Weight { get; set; }
        public bool IsWeeeitem { get; set; }
        public bool UsesSupplementaryUnit { get; set; }
        public bool SuppressNetMass { get; set; }
        public decimal SupplementaryUnitConversionRatio { get; set; }
        public bool UsesRcv { get; set; }
        public string? CountryOfOrigin { get; set; }
        public short StocktakeCyclePeriod { get; set; }
        public string? LandedCosts { get; set; }
    }
}
