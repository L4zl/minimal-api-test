using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TshumanResourceChargeRateLink
    {
        public long TshumanResourceChargeRateLinkId { get; set; }
        public long TshumanResourceId { get; set; }
        public long TschargeRateId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TschargeRate TschargeRate { get; set; } = null!;
        public virtual TshumanResource TshumanResource { get; set; } = null!;
    }
}
