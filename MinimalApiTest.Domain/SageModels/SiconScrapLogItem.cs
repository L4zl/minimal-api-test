using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconScrapLogItem
    {
        public long ScrapLogItemId { get; set; }
        public long? SiWorksOrder { get; set; }
        public long? SiWorksOrderLine { get; set; }
        public long? StockItem { get; set; }
        public decimal? ScrapCost { get; set; }
        public string Reason { get; set; } = null!;
        public decimal? Quantity { get; set; }
    }
}
