using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmeventSubCriterion
    {
        public long SiconTcmeventSubCriteriaId { get; set; }
        public long SiconTcmeventSubscriptionId { get; set; }
        public string CriteriaKey { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual SiconTcmeventSubscription SiconTcmeventSubscription { get; set; } = null!;
    }
}
