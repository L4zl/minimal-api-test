using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TshumanResourceCostRateLink
    {
        public long TshumanResourceCostRateLinkId { get; set; }
        public long TshumanResourceId { get; set; }
        public long TscostRateId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TscostRate TscostRate { get; set; } = null!;
        public virtual TshumanResource TshumanResource { get; set; } = null!;
    }
}
