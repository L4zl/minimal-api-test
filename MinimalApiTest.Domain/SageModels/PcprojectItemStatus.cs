using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectItemStatus
    {
        public PcprojectItemStatus()
        {
            PccostItemTypes = new HashSet<PccostItemType>();
            PcgroupingLevels = new HashSet<PcgroupingLevel>();
            PcprojectItems = new HashSet<PcprojectItem>();
            PcprojectLevels = new HashSet<PcprojectLevel>();
        }

        public long PcprojectItemStatusId { get; set; }
        public string Description { get; set; } = null!;
        public bool AllowCosts { get; set; }
        public bool AllowRevenue { get; set; }
        public bool AllowDeletion { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PccostItemType> PccostItemTypes { get; set; }
        public virtual ICollection<PcgroupingLevel> PcgroupingLevels { get; set; }
        public virtual ICollection<PcprojectItem> PcprojectItems { get; set; }
        public virtual ICollection<PcprojectLevel> PcprojectLevels { get; set; }
    }
}
