using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Old200BomcostType
    {
        public Old200BomcostType()
        {
            BomcostItems = new HashSet<BomcostItem>();
        }

        public long BomcostTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomcostItem> BomcostItems { get; set; }
    }
}
