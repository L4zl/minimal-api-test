using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Unit
    {
        public Unit()
        {
            ProductGroupUnits = new HashSet<ProductGroupUnit>();
            StockItemUnits = new HashSet<StockItemUnit>();
        }

        public long UnitId { get; set; }
        public string Name { get; set; } = null!;
        public decimal MultipleOfBaseUnit { get; set; }
        public bool EachValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<ProductGroupUnit> ProductGroupUnits { get; set; }
        public virtual ICollection<StockItemUnit> StockItemUnits { get; set; }
    }
}
