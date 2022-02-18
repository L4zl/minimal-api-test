using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbbankFeedAccount
    {
        public CbbankFeedAccount()
        {
            Cbaccounts = new HashSet<Cbaccount>();
        }

        public long CbbankFeedAccountId { get; set; }
        public string AccountName { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public DateTime? LastDownloadDateTime { get; set; }
        public int LastTransactionDownloadCount { get; set; }
        public string AccountGuid { get; set; } = null!;
        public string SiteAccountGuid { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<Cbaccount> Cbaccounts { get; set; }
    }
}
