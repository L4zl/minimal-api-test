using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkfulfilmentSequenceType
    {
        public StkfulfilmentSequenceType()
        {
            StockItems = new HashSet<StockItem>();
        }

        public long StkfulfilmentSequenceTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
