using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistMinStockCalc
    {
        public long SiconDistMinStockCalcId { get; set; }
        public long? ItemId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? ProductGroupCode { get; set; }
        public string? WarehouseName { get; set; }
        public long? WarehouseId { get; set; }
        public decimal? CurrentMinimumLevel { get; set; }
        public decimal? CurrentMaximumLevel { get; set; }
        public decimal? FreeStock { get; set; }
        public long? PreferredSupplierId { get; set; }
        public long? SiconDistStockItemId { get; set; }
        public decimal? SiDistSupSafetyMargin { get; set; }
        public decimal? SiDistSupDefaultLeadTime { get; set; }
        public decimal? PreferredSupplierLeadTime { get; set; }
        public long? PreferredSupLeadTimeUnitId { get; set; }
        public int? SiDistItemForecastRounding { get; set; }
        public long? SupplierId { get; set; }
        public string? Manufacturer { get; set; }
        public decimal? DaysInTheMonth { get; set; }
        public decimal? DefaultForecastRounding { get; set; }
        public decimal? LeadTime { get; set; }
        public decimal? SafetyMargin { get; set; }
        public decimal? LastThreeMonthsAvgUsage { get; set; }
        public decimal? LastOneYearAvgUsage { get; set; }
        public decimal? LastTwoYearAvgUsage { get; set; }
    }
}
