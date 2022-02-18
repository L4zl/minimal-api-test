using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcoverheadUpliftRateModifier
    {
        public PcoverheadUpliftRateModifier()
        {
            PccostItemTypes = new HashSet<PccostItemType>();
        }

        public long PcoverheadUpliftRateModifierId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PccostItemType> PccostItemTypes { get; set; }
    }
}
