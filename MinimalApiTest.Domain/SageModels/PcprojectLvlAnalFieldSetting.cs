using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectLvlAnalFieldSetting
    {
        public long PcprojectLvlAnalFieldSettingId { get; set; }
        public short SequenceNumber { get; set; }
        public long PcprojectLevelId { get; set; }
        public long PcanalysisFieldId { get; set; }
        public bool DisplayEnabled { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcanalysisField PcanalysisField { get; set; } = null!;
        public virtual PcprojectLevel PcprojectLevel { get; set; } = null!;
    }
}
