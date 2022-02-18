using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TscostRate
    {
        public TscostRate()
        {
            TshumanResourceCostRateLinks = new HashSet<TshumanResourceCostRateLink>();
            TsresourceCostRateLinks = new HashSet<TsresourceCostRateLink>();
            TstimeRecords = new HashSet<TstimeRecord>();
        }

        public long TscostRateId { get; set; }
        public long? TscostRateTypeId { get; set; }
        public decimal CostRateValue { get; set; }
        public long? TschargeRateTypeId { get; set; }
        public bool IsDefault { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool IsFromPayRate { get; set; }
        public long? TspayRateTypeId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TschargeRateType? TschargeRateType { get; set; }
        public virtual TscostRateType? TscostRateType { get; set; }
        public virtual TspayRateType? TspayRateType { get; set; }
        public virtual ICollection<TshumanResourceCostRateLink> TshumanResourceCostRateLinks { get; set; }
        public virtual ICollection<TsresourceCostRateLink> TsresourceCostRateLinks { get; set; }
        public virtual ICollection<TstimeRecord> TstimeRecords { get; set; }
    }
}
