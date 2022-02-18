using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomallocComponent
    {
        public BomallocComponent()
        {
            BomallocBalances = new HashSet<BomallocBalance>();
        }

        public long BomallocComponentId { get; set; }
        public long? BomallocationId { get; set; }
        public long StockItemId { get; set; }
        public decimal Quantity { get; set; }
        public long? OriginalStockItem { get; set; }
        public decimal OriginalQuantity { get; set; }
        public bool IsNewAllocComponent { get; set; }
        public decimal UsedQuantity { get; set; }
        public decimal UnallocatedQuantity { get; set; }
        public long? BomallocFinishedItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomallocFinishedItem? BomallocFinishedItem { get; set; }
        public virtual Old200Bomallocation? Bomallocation { get; set; }
        public virtual ICollection<BomallocBalance> BomallocBalances { get; set; }
    }
}
