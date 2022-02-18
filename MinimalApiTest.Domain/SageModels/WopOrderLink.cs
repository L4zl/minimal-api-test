using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopOrderLink
    {
        public long WopOrderLinkId { get; set; }
        public long WopOrderId { get; set; }
        public decimal QuantityRequired { get; set; }
        public long? ParentWopOrderId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopOrder? ParentWopOrder { get; set; }
        public virtual WopOrder WopOrder { get; set; } = null!;
    }
}
