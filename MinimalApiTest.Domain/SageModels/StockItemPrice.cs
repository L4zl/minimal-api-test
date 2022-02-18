using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemPrice
    {
        public long StockItemPriceId { get; set; }
        public long ItemId { get; set; }
        public long PriceBandId { get; set; }
        public decimal Price { get; set; }
        public bool UseStandard { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual PriceBand PriceBand { get; set; } = null!;
    }
}
