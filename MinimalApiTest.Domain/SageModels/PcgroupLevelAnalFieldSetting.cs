﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcgroupLevelAnalFieldSetting
    {
        public long PcgroupLevelAnalFieldSettingId { get; set; }
        public long PcgroupingLevelId { get; set; }
        public long PcanalysisFieldId { get; set; }
        public short SequenceNumber { get; set; }
        public bool DisplayEnabled { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcanalysisField PcanalysisField { get; set; } = null!;
        public virtual PcgroupingLevel PcgroupingLevel { get; set; } = null!;
    }
}