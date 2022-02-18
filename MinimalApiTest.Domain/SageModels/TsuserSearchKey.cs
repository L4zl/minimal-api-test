using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsuserSearchKey
    {
        public TsuserSearchKey()
        {
            TsexpensesClientConfigs = new HashSet<TsexpensesClientConfig>();
            TstimesheetClientConfigs = new HashSet<TstimesheetClientConfig>();
        }

        public long TsuserSearchKeyId { get; set; }
        public string? Description { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<TsexpensesClientConfig> TsexpensesClientConfigs { get; set; }
        public virtual ICollection<TstimesheetClientConfig> TstimesheetClientConfigs { get; set; }
    }
}
