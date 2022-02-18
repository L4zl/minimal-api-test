using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbpaymentCloudProvider
    {
        public CbpaymentCloudProvider()
        {
            CbpaymentCloudProviderBanks = new HashSet<CbpaymentCloudProviderBank>();
        }

        public long CbpaymentCloudProviderId { get; set; }
        public string ServiceProviderKey { get; set; } = null!;
        public string ServiceProviderName { get; set; } = null!;
        public string ServiceProviderAccountKey { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<CbpaymentCloudProviderBank> CbpaymentCloudProviderBanks { get; set; }
    }
}
