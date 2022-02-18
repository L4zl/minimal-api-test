using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectItemHierarchy
    {
        public long PcprojectItemHierarchyId { get; set; }
        public long PcprojectItemId { get; set; }
        public long BelongsToPcprojectItemId { get; set; }
        public long PctopLevelParentId { get; set; }
        public long PcimmediateParentId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem BelongsToPcprojectItem { get; set; } = null!;
        public virtual PcprojectItem PcimmediateParent { get; set; } = null!;
        public virtual PcprojectItem PcprojectItem { get; set; } = null!;
        public virtual PcprojectItem PctopLevelParent { get; set; } = null!;
    }
}
