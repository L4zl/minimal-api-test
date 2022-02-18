using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcdisplayFeature
    {
        public PcdisplayFeature()
        {
            PccostItemTypeFeatureSettings = new HashSet<PccostItemTypeFeatureSetting>();
            PcgroupLevelFeatureSettings = new HashSet<PcgroupLevelFeatureSetting>();
            PcprojectLvlFeatureSettings = new HashSet<PcprojectLvlFeatureSetting>();
        }

        public long PcdisplayFeatureId { get; set; }
        public long? PcdisplayFeatureGroupId { get; set; }
        public string Name { get; set; } = null!;
        public bool UseForCostItemType { get; set; }
        public bool UseForGroupingLevel { get; set; }
        public bool UseForProjectLevel { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcdisplayFeatureGroup? PcdisplayFeatureGroup { get; set; }
        public virtual ICollection<PccostItemTypeFeatureSetting> PccostItemTypeFeatureSettings { get; set; }
        public virtual ICollection<PcgroupLevelFeatureSetting> PcgroupLevelFeatureSettings { get; set; }
        public virtual ICollection<PcprojectLvlFeatureSetting> PcprojectLvlFeatureSettings { get; set; }
    }
}
