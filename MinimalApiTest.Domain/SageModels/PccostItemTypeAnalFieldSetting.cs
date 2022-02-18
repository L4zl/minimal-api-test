using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PccostItemTypeAnalFieldSetting
    {
        public long PccostItemTypeAnalFieldSettingId { get; set; }
        public long PccostItemTypeId { get; set; }
        public long PcanalysisFieldId { get; set; }
        public short SequenceNumber { get; set; }
        public bool DisplayEnabled { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcanalysisField PcanalysisField { get; set; } = null!;
        public virtual PccostItemType PccostItemType { get; set; } = null!;
    }
}
