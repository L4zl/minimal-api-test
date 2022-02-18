using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TshumanResourcePayRateLink
    {
        public long TshumanResourcePayRateLinkId { get; set; }
        public long TshumanResourceId { get; set; }
        public long TspayRateId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TshumanResource TshumanResource { get; set; } = null!;
        public virtual TspayRate TspayRate { get; set; } = null!;
    }
}
