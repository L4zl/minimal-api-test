using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopBomComponentLineLink
    {
        public long WopBomComponentLineLinkId { get; set; }
        public long BomComponentLineId { get; set; }
        public long WopComponentLineId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomComponentLine BomComponentLine { get; set; } = null!;
        public virtual WopComponentLine WopComponentLine { get; set; } = null!;
    }
}
