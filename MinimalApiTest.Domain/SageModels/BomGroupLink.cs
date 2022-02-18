using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomGroupLink
    {
        public long BomGroupLinkId { get; set; }
        public long BomGroupId { get; set; }
        public long BomBuildPackageId { get; set; }
        public decimal Quantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomBuildPackage BomBuildPackage { get; set; } = null!;
        public virtual BomGroup BomGroup { get; set; } = null!;
    }
}
