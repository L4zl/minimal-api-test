using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomcostItemUnit
    {
        public long BomcostItemUnitId { get; set; }
        public long? BomcostItemId { get; set; }
        public long BomunitId { get; set; }
        public decimal MultipleOfBaseUnit { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomcostItem? BomcostItem { get; set; }
        public virtual Bomunit Bomunit { get; set; } = null!;
    }
}
