using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcgroupingLevel
    {
        public PcgroupingLevel()
        {
            PccostGroups = new HashSet<PccostGroup>();
            PcgroupLevelAnalFieldSettings = new HashSet<PcgroupLevelAnalFieldSetting>();
            PcgroupLevelFeatureSettings = new HashSet<PcgroupLevelFeatureSetting>();
        }

        public long PcgroupingLevelId { get; set; }
        public string Title { get; set; } = null!;
        public long PcprojectItemStatusId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItemStatus PcprojectItemStatus { get; set; } = null!;
        public virtual ICollection<PccostGroup> PccostGroups { get; set; }
        public virtual ICollection<PcgroupLevelAnalFieldSetting> PcgroupLevelAnalFieldSettings { get; set; }
        public virtual ICollection<PcgroupLevelFeatureSetting> PcgroupLevelFeatureSettings { get; set; }
    }
}
