using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopauthRule
    {
        public PopauthRule()
        {
            PopauthPrincipals = new HashSet<PopauthPrincipal>();
        }

        public long PopauthRuleId { get; set; }
        public decimal LessThanValue { get; set; }
        public decimal GreaterThanOrEqualValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long AuthorisationGroup { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long PopauthRuleSourceId { get; set; }

        public virtual PopauthRuleSource PopauthRuleSource { get; set; } = null!;
        public virtual ICollection<PopauthPrincipal> PopauthPrincipals { get; set; }
    }
}
