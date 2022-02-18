using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AnalysisCode
    {
        public AnalysisCode()
        {
            AnalysisCodeValues = new HashSet<AnalysisCodeValue>();
        }

        public long AnalysisCodeId { get; set; }
        public string Name { get; set; } = null!;
        public bool AllowOvertype { get; set; }
        public bool AllowNewOnEntry { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<AnalysisCodeValue> AnalysisCodeValues { get; set; }
    }
}
