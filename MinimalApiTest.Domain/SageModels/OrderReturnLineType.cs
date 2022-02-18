using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class OrderReturnLineType
    {
        public OrderReturnLineType()
        {
            PoporderReturnLineArches = new HashSet<PoporderReturnLineArch>();
            PoporderReturnLines = new HashSet<PoporderReturnLine>();
            SoporderReturnLineArches = new HashSet<SoporderReturnLineArch>();
            SoporderReturnLines = new HashSet<SoporderReturnLine>();
            SoppreferredItems = new HashSet<SoppreferredItem>();
            StockItemCrossSellItems = new HashSet<StockItemCrossSellItem>();
        }

        public long OrderReturnLineTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoporderReturnLineArch> PoporderReturnLineArches { get; set; }
        public virtual ICollection<PoporderReturnLine> PoporderReturnLines { get; set; }
        public virtual ICollection<SoporderReturnLineArch> SoporderReturnLineArches { get; set; }
        public virtual ICollection<SoporderReturnLine> SoporderReturnLines { get; set; }
        public virtual ICollection<SoppreferredItem> SoppreferredItems { get; set; }
        public virtual ICollection<StockItemCrossSellItem> StockItemCrossSellItems { get; set; }
    }
}
