using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CostingMethod
    {
        public CostingMethod()
        {
            ProductGroups = new HashSet<ProductGroup>();
        }

        public long CostingMethodId { get; set; }
        public string CostingMethodName { get; set; } = null!;

        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
    }
}
