using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemStatus
    {
        public StockItemStatus()
        {
            StockItems = new HashSet<StockItem>();
        }

        public long StockItemStatusId { get; set; }
        public string StockItemStatusName { get; set; } = null!;

        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
