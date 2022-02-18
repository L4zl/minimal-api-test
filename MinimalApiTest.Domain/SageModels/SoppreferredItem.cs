using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoppreferredItem
    {
        public long SoppreferredItemId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long? ItemId { get; set; }
        public long LineTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem? Item { get; set; }
        public virtual OrderReturnLineType LineType { get; set; } = null!;
        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
    }
}
