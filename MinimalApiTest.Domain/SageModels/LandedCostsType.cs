using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class LandedCostsType
    {
        public LandedCostsType()
        {
            PoporderReturnLineArches = new HashSet<PoporderReturnLineArch>();
            PoporderReturnLines = new HashSet<PoporderReturnLine>();
            ProductGroups = new HashSet<ProductGroup>();
            StockItemSuppliers = new HashSet<StockItemSupplier>();
            StockItems = new HashSet<StockItem>();
        }

        public long LandedCostsTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoporderReturnLineArch> PoporderReturnLineArches { get; set; }
        public virtual ICollection<PoporderReturnLine> PoporderReturnLines { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<StockItemSupplier> StockItemSuppliers { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
