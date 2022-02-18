using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceableType
    {
        public TraceableType()
        {
            PoporderReturnLineArches = new HashSet<PoporderReturnLineArch>();
            PoporderReturnLines = new HashSet<PoporderReturnLine>();
            ProductGroups = new HashSet<ProductGroup>();
            SoporderReturnLineArches = new HashSet<SoporderReturnLineArch>();
            StockItems = new HashSet<StockItem>();
            TraceableItemArches = new HashSet<TraceableItemArch>();
            TraceableItems = new HashSet<TraceableItem>();
        }

        public long TraceableTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoporderReturnLineArch> PoporderReturnLineArches { get; set; }
        public virtual ICollection<PoporderReturnLine> PoporderReturnLines { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<SoporderReturnLineArch> SoporderReturnLineArches { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<TraceableItemArch> TraceableItemArches { get; set; }
        public virtual ICollection<TraceableItem> TraceableItems { get; set; }
    }
}
