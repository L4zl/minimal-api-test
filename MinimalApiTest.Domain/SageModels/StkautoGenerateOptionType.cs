using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkautoGenerateOptionType
    {
        public StkautoGenerateOptionType()
        {
            StockItems = new HashSet<StockItem>();
        }

        public long StkautoGenerateOptionTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
