using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcanalysisFieldList
    {
        public long PcanalysisFieldListId { get; set; }
        public long? PcanalysisField1Id { get; set; }
        public long? PcanalysisField2Id { get; set; }
        public long? PcanalysisField3Id { get; set; }
        public long? PcanalysisField4Id { get; set; }
        public long? PcanalysisField5Id { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcanalysisField? PcanalysisField1 { get; set; }
        public virtual PcanalysisField? PcanalysisField2 { get; set; }
        public virtual PcanalysisField? PcanalysisField3 { get; set; }
        public virtual PcanalysisField? PcanalysisField4 { get; set; }
        public virtual PcanalysisField? PcanalysisField5 { get; set; }
    }
}
