using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcpricingRuleMethodType
    {
        public PcpricingRuleMethodType()
        {
            PctimeMaterialsPriceRules = new HashSet<PctimeMaterialsPriceRule>();
        }

        public long PcpricingRuleMethodTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<PctimeMaterialsPriceRule> PctimeMaterialsPriceRules { get; set; }
    }
}
