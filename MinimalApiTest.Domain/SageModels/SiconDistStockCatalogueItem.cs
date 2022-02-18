using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistStockCatalogueItem
    {
        public long SiconDistStockCatalogueItemId { get; set; }
        public long? SupplierId { get; set; }
        public string StockCode { get; set; } = null!;
        public string StockName { get; set; } = null!;
        public string ProductGroup { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string UnitOfMeasure { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public bool Deleted { get; set; }
    }
}
