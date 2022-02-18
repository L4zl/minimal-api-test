using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoppreReceiptAlloc
    {
        public long SoppreReceiptAllocId { get; set; }
        public long SopallocationLineId { get; set; }
        public long WarehouseItemId { get; set; }
        public long StockItemId { get; set; }
        public string Priority { get; set; } = null!;
        public DateTime? PromisedDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SopallocationLine SopallocationLine { get; set; } = null!;
        public virtual StockItem StockItem { get; set; } = null!;
        public virtual WarehouseItem WarehouseItem { get; set; } = null!;
    }
}
