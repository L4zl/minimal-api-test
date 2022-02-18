using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopAllocationLine
    {
        public WopAllocationLine()
        {
            WopAllocationBalances = new HashSet<WopAllocationBalance>();
        }

        public long WopAllocationLineId { get; set; }
        public long? WopComponentLineId { get; set; }
        public string StockCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal AllocationQuantity { get; set; }
        public long WarehouseId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopComponentLine? WopComponentLine { get; set; }
        public virtual ICollection<WopAllocationBalance> WopAllocationBalances { get; set; }
    }
}
