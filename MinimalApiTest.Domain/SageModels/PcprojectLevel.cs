using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectLevel
    {
        public PcprojectLevel()
        {
            PcprojectItems = new HashSet<PcprojectItem>();
            PcprojectLvlAnalFieldSettings = new HashSet<PcprojectLvlAnalFieldSetting>();
            PcprojectLvlFeatureSettings = new HashSet<PcprojectLvlFeatureSetting>();
        }

        public long PcprojectLevelId { get; set; }
        public string Title { get; set; } = null!;
        public long PcprojectLevelBillingMethodId { get; set; }
        public long PcprojectItemStatusId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItemStatus PcprojectItemStatus { get; set; } = null!;
        public virtual PcprojectLevelBillingMethod PcprojectLevelBillingMethod { get; set; } = null!;
        public virtual ICollection<PcprojectItem> PcprojectItems { get; set; }
        public virtual ICollection<PcprojectLvlAnalFieldSetting> PcprojectLvlAnalFieldSettings { get; set; }
        public virtual ICollection<PcprojectLvlFeatureSetting> PcprojectLvlFeatureSettings { get; set; }
    }
}
