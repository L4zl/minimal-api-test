using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysfeatureAreaUsage
    {
        public long SysfeatureAreaUsageId { get; set; }
        public long SysuserLoginId { get; set; }
        public DateTime AccessedAt { get; set; }
        public bool UsesMultiLeggedTransaction { get; set; }
        public string FeatureArea { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysuserLogin SysuserLogin { get; set; } = null!;
    }
}
