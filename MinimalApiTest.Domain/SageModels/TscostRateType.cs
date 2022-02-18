using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TscostRateType
    {
        public TscostRateType()
        {
            TscostRates = new HashSet<TscostRate>();
        }

        public long TscostRateTypeId { get; set; }
        public string Description { get; set; } = null!;
        public string Code { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<TscostRate> TscostRates { get; set; }
    }
}
