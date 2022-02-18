using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomAllocationWopOrderLink
    {
        public long BomAllocationWopOrderLinkId { get; set; }
        public long BomAllocationId { get; set; }
        public long WopOrderId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomAllocation BomAllocation { get; set; } = null!;
        public virtual WopOrder WopOrder { get; set; } = null!;
    }
}
