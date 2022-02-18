using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbpaymentCloudProviderBank
    {
        public long CbpaymentCloudProviderBankId { get; set; }
        public long CbpaymentCloudProviderId { get; set; }
        public long ProviderBankAccountId { get; set; }
        public string ServiceProviderAccountKey { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CbpaymentCloudProvider CbpaymentCloudProvider { get; set; } = null!;
        public virtual Cbaccount ProviderBankAccount { get; set; } = null!;
    }
}
