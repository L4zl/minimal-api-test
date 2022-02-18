using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemAverageCostHistory
    {
        public long StockItemAverageCostHistoryId { get; set; }
        public long ItemId { get; set; }
        public decimal AverageCostValue { get; set; }
        public DateTime ChangedDate { get; set; }
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }

        public virtual StockItem Item { get; set; } = null!;
    }
}
