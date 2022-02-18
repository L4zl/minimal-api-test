using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomGroup
    {
        public BomGroup()
        {
            BomGroupLinks = new HashSet<BomGroupLink>();
        }

        public long BomGroupId { get; set; }
        public string Reference { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<BomGroupLink> BomGroupLinks { get; set; }
    }
}
