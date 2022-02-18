using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemStandardCostHistory
    {
        public long StockItemStandardCostHistoryId { get; set; }
        public long ItemId { get; set; }
        public decimal StandardCostValue { get; set; }
        public DateTime ChangedDate { get; set; }
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }

        public virtual StockItem Item { get; set; } = null!;
    }
}
