using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TspayRateType
    {
        public TspayRateType()
        {
            TscostRates = new HashSet<TscostRate>();
            TspayRates = new HashSet<TspayRate>();
        }

        public long TspayRateTypeId { get; set; }
        public string Description { get; set; } = null!;
        public string Code { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long? ProviderConfigurationId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<TscostRate> TscostRates { get; set; }
        public virtual ICollection<TspayRate> TspayRates { get; set; }
    }
}
