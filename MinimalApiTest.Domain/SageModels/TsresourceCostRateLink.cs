using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsresourceCostRateLink
    {
        public long TsresourceCostRateLink1 { get; set; }
        public long TsresourceHierarchyId { get; set; }
        public long TscostRateId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TscostRate TscostRate { get; set; } = null!;
        public virtual TsresourceHierarchy TsresourceHierarchy { get; set; } = null!;
    }
}
