using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MseWarehouse
    {
        public long MseWarehouseId { get; set; }
        public long WarehouseId { get; set; }
        public bool IsComponentSource { get; set; }
        public long? MseContactId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MseContact? MseContact { get; set; }
    }
}
