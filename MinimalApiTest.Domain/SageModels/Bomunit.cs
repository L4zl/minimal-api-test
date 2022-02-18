using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Bomunit
    {
        public Bomunit()
        {
            BomcostItemUnits = new HashSet<BomcostItemUnit>();
            BomcostItems = new HashSet<BomcostItem>();
        }

        public long BomunitId { get; set; }
        public string Name { get; set; } = null!;
        public decimal MultipleOfBaseUnit { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<BomcostItemUnit> BomcostItemUnits { get; set; }
        public virtual ICollection<BomcostItem> BomcostItems { get; set; }
    }
}
