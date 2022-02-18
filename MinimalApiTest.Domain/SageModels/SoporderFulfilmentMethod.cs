using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderFulfilmentMethod
    {
        public SoporderFulfilmentMethod()
        {
            SoporderReturnLineArches = new HashSet<SoporderReturnLineArch>();
            SoporderReturnLines = new HashSet<SoporderReturnLine>();
            StockItems = new HashSet<StockItem>();
        }

        public long SoporderFulfilmentMethodId { get; set; }
        public string SoporderFulfilmentMethodName { get; set; } = null!;

        public virtual ICollection<SoporderReturnLineArch> SoporderReturnLineArches { get; set; }
        public virtual ICollection<SoporderReturnLine> SoporderReturnLines { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}
