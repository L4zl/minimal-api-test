using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemCrossSellItem
    {
        public long StockItemCrossSellItemId { get; set; }
        public long ItemId { get; set; }
        public long LineTypeId { get; set; }
        public long? ItemCrossSellItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual StockItem? ItemCrossSellItem { get; set; }
        public virtual OrderReturnLineType LineType { get; set; } = null!;
    }
}
