using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkautoGenerateSeparator
    {
        public StkautoGenerateSeparator()
        {
            StockItems = new HashSet<StockItem>();
        }

        public long StkautoGenerateSeparatorId { get; set; }
        public string Name { get; set; } = null!;
        public string SeparatorCharacter { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
