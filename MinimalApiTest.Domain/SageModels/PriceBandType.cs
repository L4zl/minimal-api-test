using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PriceBandType
    {
        public PriceBandType()
        {
            PriceBands = new HashSet<PriceBand>();
        }

        public long PriceBandTypeId { get; set; }
        public string Type { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PriceBand> PriceBands { get; set; }
    }
}
