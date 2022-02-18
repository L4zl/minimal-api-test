using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlpendCustomerAnalysis
    {
        public long SlpendCustomerAnalysisId { get; set; }
        public long SlpendCustomerAccountId { get; set; }
        public string AnalysisName { get; set; } = null!;
        public string AnalysisValue { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlpendCustomerAccount SlpendCustomerAccount { get; set; } = null!;
    }
}
