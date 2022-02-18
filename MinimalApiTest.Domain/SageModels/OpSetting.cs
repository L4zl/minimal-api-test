using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class OpSetting
    {
        public long OpSettingId { get; set; }
        public decimal OpSequenceStart { get; set; }
        public decimal OpSequenceStep { get; set; }
        public bool OpSequenceInOrder { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
