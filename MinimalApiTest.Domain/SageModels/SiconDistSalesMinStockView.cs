using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSalesMinStockView
    {
        public long ItemId { get; set; }
        public long SiconDistStockItemId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ProductGroupCode { get; set; } = null!;
        public string WarehouseName { get; set; } = null!;
        public long WarehouseId { get; set; }
        public decimal CurrentMinimumLevel { get; set; }
        public decimal CurrentMaximumLevel { get; set; }
        public long? PreferedSupplierId { get; set; }
        public long? SupplierId { get; set; }
        public bool? Preferred { get; set; }
        public double? FreeStock { get; set; }
        public decimal? SiDistSupSafetyMargin { get; set; }
        public decimal? SiDistSupDefaultLeadTime { get; set; }
        public short? PreferredSupplierLeadTime { get; set; }
        public long? PreferredSupLeadTimeUnitId { get; set; }
        public int? SiDistItemForecastRounding { get; set; }
        public string Manufacturer { get; set; } = null!;
        public decimal? StockItemSafetyMargin { get; set; }
    }
}
