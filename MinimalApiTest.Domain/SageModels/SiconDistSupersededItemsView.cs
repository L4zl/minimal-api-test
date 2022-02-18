using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSupersededItemsView
    {
        public long? ItemId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public decimal FreeStockQuantity { get; set; }
        public long? SupersededItemId { get; set; }
        public string SupersededItemCode { get; set; } = null!;
        public string SupersededItemName { get; set; } = null!;
        public decimal SupersededFreeStockQuantity { get; set; }
    }
}
