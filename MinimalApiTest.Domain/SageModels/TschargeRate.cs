using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TschargeRate
    {
        public TschargeRate()
        {
            TshumanResourceChargeRateLinks = new HashSet<TshumanResourceChargeRateLink>();
            TsresourceChargeRateLinks = new HashSet<TsresourceChargeRateLink>();
            TstimeRecords = new HashSet<TstimeRecord>();
        }

        public long TschargeRateId { get; set; }
        public long TschargeRateTypeId { get; set; }
        public decimal ChargeRateValue { get; set; }
        public bool IsDefault { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TschargeRateType TschargeRateType { get; set; } = null!;
        public virtual ICollection<TshumanResourceChargeRateLink> TshumanResourceChargeRateLinks { get; set; }
        public virtual ICollection<TsresourceChargeRateLink> TsresourceChargeRateLinks { get; set; }
        public virtual ICollection<TstimeRecord> TstimeRecords { get; set; }
    }
}
