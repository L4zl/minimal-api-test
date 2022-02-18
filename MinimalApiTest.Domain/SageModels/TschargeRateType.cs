using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TschargeRateType
    {
        public TschargeRateType()
        {
            TschargeRates = new HashSet<TschargeRate>();
            TschgRateTypePriceModLinks = new HashSet<TschgRateTypePriceModLink>();
            TscostRates = new HashSet<TscostRate>();
        }

        public long TschargeRateTypeId { get; set; }
        public string Description { get; set; } = null!;
        public string Code { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<TschargeRate> TschargeRates { get; set; }
        public virtual ICollection<TschgRateTypePriceModLink> TschgRateTypePriceModLinks { get; set; }
        public virtual ICollection<TscostRate> TscostRates { get; set; }
    }
}
