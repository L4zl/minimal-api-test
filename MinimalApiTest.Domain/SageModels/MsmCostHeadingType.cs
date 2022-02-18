using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmCostHeadingType
    {
        public MsmCostHeadingType()
        {
            BomCostSessionTotals = new HashSet<BomCostSessionTotal>();
            BomCosts = new HashSet<BomCost>();
            MsmCostHeadings = new HashSet<MsmCostHeading>();
        }

        public long MsmCostHeadingTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomCostSessionTotal> BomCostSessionTotals { get; set; }
        public virtual ICollection<BomCost> BomCosts { get; set; }
        public virtual ICollection<MsmCostHeading> MsmCostHeadings { get; set; }
    }
}
