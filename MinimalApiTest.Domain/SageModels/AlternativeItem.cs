using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AlternativeItem
    {
        public long AlternativeItemId { get; set; }
        public long ItemId { get; set; }
        public long ItemAlternativeId { get; set; }
        public bool Preferred { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual StockItem ItemAlternative { get; set; } = null!;
    }
}
