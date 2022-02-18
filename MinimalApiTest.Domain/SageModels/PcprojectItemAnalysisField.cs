using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectItemAnalysisField
    {
        public long PcprojectItemAnalysisFieldId { get; set; }
        public long PcprojectItemId { get; set; }
        public long PcanalysisFieldId { get; set; }
        public long? PcanalysisFieldValueId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcanalysisFieldValue? PcanalysisFieldValue { get; set; }
        public virtual PcprojectItem PcprojectItem { get; set; } = null!;
    }
}
