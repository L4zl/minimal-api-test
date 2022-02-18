using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PccostItemAnalysisField
    {
        public long PccostItemAnalysisFieldId { get; set; }
        public long PccostItemId { get; set; }
        public long PcanalysisFieldId { get; set; }
        public long? PcanalysisFieldValueId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcanalysisField PcanalysisField { get; set; } = null!;
        public virtual PcanalysisFieldValue? PcanalysisFieldValue { get; set; }
        public virtual PccostItem PccostItem { get; set; } = null!;
    }
}
