using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerPriceMapping
    {
        public long SlcustomerPriceMappingId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long PriceBandId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PriceBand PriceBand { get; set; } = null!;
        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
    }
}
