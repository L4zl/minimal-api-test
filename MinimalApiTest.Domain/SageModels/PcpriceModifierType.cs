using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcpriceModifierType
    {
        public PcpriceModifierType()
        {
            PctimeMaterialsPriceRules = new HashSet<PctimeMaterialsPriceRule>();
        }

        public long PcpriceModifierTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PctimeMaterialsPriceRule> PctimeMaterialsPriceRules { get; set; }
    }
}
