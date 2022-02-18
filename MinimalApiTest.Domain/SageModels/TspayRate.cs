using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TspayRate
    {
        public TspayRate()
        {
            TshumanResourcePayRateLinks = new HashSet<TshumanResourcePayRateLink>();
            TstimeRecords = new HashSet<TstimeRecord>();
        }

        public long TspayRateId { get; set; }
        public string Description { get; set; } = null!;
        public decimal PayRateValue { get; set; }
        public bool IsDefault { get; set; }
        public bool IsAssignable { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long TspayRateTypeId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TspayRateType TspayRateType { get; set; } = null!;
        public virtual ICollection<TshumanResourcePayRateLink> TshumanResourcePayRateLinks { get; set; }
        public virtual ICollection<TstimeRecord> TstimeRecords { get; set; }
    }
}
