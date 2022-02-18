using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkshelfLifeType
    {
        public StkshelfLifeType()
        {
            StockItems = new HashSet<StockItem>();
        }

        public long StkshelfLifeTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
