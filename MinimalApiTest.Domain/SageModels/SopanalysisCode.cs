using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopanalysisCode
    {
        public long SopanalysisCodeId { get; set; }
        public bool CanAmend { get; set; }
        public bool IncludeInHistory { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long AnalysisCodeMappingId { get; set; }
        public bool DefaultFromCustomer { get; set; }
        public long? CustomerAnalysisCodeMappingId { get; set; }
        public long? TranHistAnalysisCodeMappingId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual AnalysisCodeMapping AnalysisCodeMapping { get; set; } = null!;
        public virtual AnalysisCodeMapping? CustomerAnalysisCodeMapping { get; set; }
        public virtual AnalysisCodeMapping? TranHistAnalysisCodeMapping { get; set; }
    }
}
