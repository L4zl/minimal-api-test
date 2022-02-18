using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomCostType
    {
        public BomCostType()
        {
            BomCosts = new HashSet<BomCost>();
        }

        public long BomCostTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<BomCost> BomCosts { get; set; }
    }
}
