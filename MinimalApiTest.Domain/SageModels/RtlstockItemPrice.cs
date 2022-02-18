using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstockItemPrice
    {
        public long StockItemPriceId { get; set; }
        public long PrdHierNodeId { get; set; }
        public long PriceBandId { get; set; }
        public decimal Price { get; set; }
        public bool UseStandard { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
