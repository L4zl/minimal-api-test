using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsactivitySearchKey
    {
        public TsactivitySearchKey()
        {
            TsexpensesClientConfigs = new HashSet<TsexpensesClientConfig>();
            TstimesheetClientConfigs = new HashSet<TstimesheetClientConfig>();
        }

        public long TsactivitySearchKeyId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string Description { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<TsexpensesClientConfig> TsexpensesClientConfigs { get; set; }
        public virtual ICollection<TstimesheetClientConfig> TstimesheetClientConfigs { get; set; }
    }
}
