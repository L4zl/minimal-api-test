using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlpendNominalAccountAnalysis
    {
        public long NlpendNominalAccountAnalysisId { get; set; }
        public long NlpendNominalAccountId { get; set; }
        public string AnalysisName { get; set; } = null!;
        public string AnalysisValue { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlpendNominalAccount NlpendNominalAccount { get; set; } = null!;
    }
}
