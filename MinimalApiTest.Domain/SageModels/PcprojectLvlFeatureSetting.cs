using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectLvlFeatureSetting
    {
        public long PcprojectLvlFeatureSettingId { get; set; }
        public long PcprojectLevelId { get; set; }
        public long PcdisplayFeatureId { get; set; }
        public bool FeatureEnabled { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcdisplayFeature PcdisplayFeature { get; set; } = null!;
        public virtual PcprojectLevel PcprojectLevel { get; set; } = null!;
    }
}
