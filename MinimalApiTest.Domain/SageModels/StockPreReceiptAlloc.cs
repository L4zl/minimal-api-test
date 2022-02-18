using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockPreReceiptAlloc
    {
        public long StockPreReceiptAllocId { get; set; }
        public long? AllocationBalanceId { get; set; }
        public long WarehouseItemId { get; set; }
        public long StockItemId { get; set; }
        public DateTime AllocationDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual AllocationBalance? AllocationBalance { get; set; }
        public virtual StockItem StockItem { get; set; } = null!;
        public virtual WarehouseItem WarehouseItem { get; set; } = null!;
    }
}
