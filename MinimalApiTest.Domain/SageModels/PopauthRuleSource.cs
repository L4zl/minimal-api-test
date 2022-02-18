using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopauthRuleSource
    {
        public PopauthRuleSource()
        {
            PopauthRules = new HashSet<PopauthRule>();
        }

        public long PopauthRuleSourceId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PopauthRule> PopauthRules { get; set; }
    }
}
