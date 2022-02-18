using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomAllocationWarehouse
    {
        public long BomAllocationWarehouseId { get; set; }
        public long BomAllocationId { get; set; }
        public long WarehouseId { get; set; }
        public string WarehouseName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomAllocation BomAllocation { get; set; } = null!;
    }
}
