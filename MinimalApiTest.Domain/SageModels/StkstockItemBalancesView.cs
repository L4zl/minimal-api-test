using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkstockItemBalancesView
    {
        public long StockItemId { get; set; }
        public string StockItemCode { get; set; } = null!;
        public string StockItemName { get; set; } = null!;
        public string ProductGroupCode { get; set; } = null!;
        public string ProductGroupDescription { get; set; } = null!;
        public string WarehouseName { get; set; } = null!;
        public string WarehouseDescription { get; set; } = null!;
        public decimal MinimumLevel { get; set; }
        public decimal ReorderLevel { get; set; }
        public decimal MaximumLevel { get; set; }
        public decimal? QuantityInStock { get; set; }
        public decimal QuantityOnOrder { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? FreeStock { get; set; }
        public decimal? QuantityUnallocatedLiveSop { get; set; }
        public decimal? ProjectedAvailableStock { get; set; }
    }
}
