using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcgroupLevelFeatureSetting
    {
        public long PcgroupLevelFeatureSettingId { get; set; }
        public long PcgroupingLevelId { get; set; }
        public long PcdisplayFeatureId { get; set; }
        public bool FeatureEnabled { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcdisplayFeature PcdisplayFeature { get; set; } = null!;
        public virtual PcgroupingLevel PcgroupingLevel { get; set; } = null!;
    }
}
