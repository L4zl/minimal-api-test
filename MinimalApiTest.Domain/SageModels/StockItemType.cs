using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockItemType
    {
        public StockItemType()
        {
            PoporderReturnLineArches = new HashSet<PoporderReturnLineArch>();
            PoporderReturnLines = new HashSet<PoporderReturnLine>();
            ProductGroups = new HashSet<ProductGroup>();
            SoporderReturnLineArches = new HashSet<SoporderReturnLineArch>();
            SoporderReturnLines = new HashSet<SoporderReturnLine>();
        }

        public long StockItemTypeId { get; set; }
        public string StockItemTypeName { get; set; } = null!;

        public virtual ICollection<PoporderReturnLineArch> PoporderReturnLineArches { get; set; }
        public virtual ICollection<PoporderReturnLine> PoporderReturnLines { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<SoporderReturnLineArch> SoporderReturnLineArches { get; set; }
        public virtual ICollection<SoporderReturnLine> SoporderReturnLines { get; set; }
    }
}
