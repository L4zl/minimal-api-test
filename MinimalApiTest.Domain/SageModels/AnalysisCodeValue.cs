using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AnalysisCodeValue
    {
        public long AnalysisCodeValueId { get; set; }
        public long AnalysisCodeId { get; set; }
        public string Value { get; set; } = null!;
        public bool IsDefault { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual AnalysisCode AnalysisCode { get; set; } = null!;
    }
}
