using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderProfitAnalysis
    {
        public SoporderProfitAnalysis()
        {
            SoporderLineProfitAnalyses = new HashSet<SoporderLineProfitAnalysis>();
        }

        public long SoporderProfitAnalysisId { get; set; }
        public long SoporderReturnId { get; set; }
        public decimal EstimatedCostValue { get; set; }
        public decimal EstProfitPercentOnRev { get; set; }
        public decimal EstProfitPercentOnCost { get; set; }
        public decimal EstimatedProfitValue { get; set; }
        public decimal IssueValue { get; set; }
        public decimal RealisedCostValue { get; set; }
        public decimal RealisedIssueValue { get; set; }
        public decimal RealisedProfitPercentOnCost { get; set; }
        public decimal RealisedProfitPercentOnRev { get; set; }
        public decimal RealisedProfitValue { get; set; }
        public bool SimpleProfitCalculationOnly { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SoporderReturn SoporderReturn { get; set; } = null!;
        public virtual ICollection<SoporderLineProfitAnalysis> SoporderLineProfitAnalyses { get; set; }
    }
}
