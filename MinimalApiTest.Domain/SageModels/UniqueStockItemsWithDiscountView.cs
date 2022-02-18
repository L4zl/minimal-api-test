using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class UniqueStockItemsWithDiscountView
    {
        public string StockItemCode { get; set; } = null!;
        public string StockItemName { get; set; } = null!;
        public string ProductGroupCode { get; set; } = null!;
        public long ProductGroupId { get; set; }
        public long ItemId { get; set; }
        public long StockItemUnitId { get; set; }
        public string UnitName { get; set; } = null!;
    }
}
