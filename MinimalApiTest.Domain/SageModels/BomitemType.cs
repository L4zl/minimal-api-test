using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomitemType
    {
        public BomitemType()
        {
            StockItems = new HashSet<StockItem>();
        }

        public long BomitemTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
