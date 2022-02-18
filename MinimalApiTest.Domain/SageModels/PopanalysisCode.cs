using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopanalysisCode
    {
        public long PopanalysisCodeId { get; set; }
        public bool CanAmend { get; set; }
        public bool IncludeInHistory { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long AnalysisCodeMappingId { get; set; }
        public bool DefaultFromSupplier { get; set; }
        public long? SupplierAnalysisCodeMappingId { get; set; }
        public long? TranHistAnalysisCodeMappingId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual AnalysisCodeMapping AnalysisCodeMapping { get; set; } = null!;
        public virtual AnalysisCodeMapping? SupplierAnalysisCodeMapping { get; set; }
        public virtual AnalysisCodeMapping? TranHistAnalysisCodeMapping { get; set; }
    }
}
