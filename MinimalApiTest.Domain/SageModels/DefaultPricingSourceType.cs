using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DefaultPricingSourceType
    {
        public DefaultPricingSourceType()
        {
            StockItemSuppliers = new HashSet<StockItemSupplier>();
        }

        public long DefaultPricingSourceTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<StockItemSupplier> StockItemSuppliers { get; set; }
    }
}
