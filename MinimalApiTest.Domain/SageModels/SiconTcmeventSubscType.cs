using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmeventSubscType
    {
        public SiconTcmeventSubscType()
        {
            SiconTcmeventSubscriptions = new HashSet<SiconTcmeventSubscription>();
        }

        public long SiconTcmeventSubscTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string Guid { get; set; } = null!;

        public virtual ICollection<SiconTcmeventSubscription> SiconTcmeventSubscriptions { get; set; }
    }
}
