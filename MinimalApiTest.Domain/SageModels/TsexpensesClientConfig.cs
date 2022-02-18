using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsexpensesClientConfig
    {
        public TsexpensesClientConfig()
        {
            TstermExpensesConfigLinks = new HashSet<TstermExpensesConfigLink>();
        }

        public long TsexpensesClientConfigId { get; set; }
        public long TsuserSearchKeyId { get; set; }
        public long TsactivitySearchKeyId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TsactivitySearchKey TsactivitySearchKey { get; set; } = null!;
        public virtual TsuserSearchKey TsuserSearchKey { get; set; } = null!;
        public virtual ICollection<TstermExpensesConfigLink> TstermExpensesConfigLinks { get; set; }
    }
}
