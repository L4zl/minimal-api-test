using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PccostItemTypeFeatureSetting
    {
        public long PccostItemTypeFeatureSettingId { get; set; }
        public long PccostItemTypeId { get; set; }
        public long PcdisplayFeatureId { get; set; }
        public bool FeatureEnabled { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PccostItemType PccostItemType { get; set; } = null!;
        public virtual PcdisplayFeature PcdisplayFeature { get; set; } = null!;
    }
}
