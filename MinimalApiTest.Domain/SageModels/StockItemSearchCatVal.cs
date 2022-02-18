using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemSearchCatVal
    {
        public long StockItemSearchCatValId { get; set; }
        public long ItemId { get; set; }
        public long SearchCategoryId { get; set; }
        public long SearchValueId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual SearchCategory SearchCategory { get; set; } = null!;
        public virtual SearchValue SearchValue { get; set; } = null!;
    }
}
