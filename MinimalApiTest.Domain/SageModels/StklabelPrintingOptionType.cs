using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StklabelPrintingOptionType
    {
        public StklabelPrintingOptionType()
        {
            PopreceiptReturnLines = new HashSet<PopreceiptReturnLine>();
            ProductGroups = new HashSet<ProductGroup>();
            StockItems = new HashSet<StockItem>();
        }

        public long StklabelPrintingOptionTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PopreceiptReturnLine> PopreceiptReturnLines { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
