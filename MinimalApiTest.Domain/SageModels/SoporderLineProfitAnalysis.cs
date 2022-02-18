using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderLineProfitAnalysis
    {
        public long SoporderLineProfitAnalysisId { get; set; }
        public long SoporderProfitAnalysisId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public decimal EstimatedCostRate { get; set; }
        public decimal EstProfitPercentOnRev { get; set; }
        public decimal EstProfitPercentOnCost { get; set; }
        public decimal EstimatedProfitValue { get; set; }
        public decimal IssueRate { get; set; }
        public decimal LineQuantity { get; set; }
        public decimal RealisedCostValue { get; set; }
        public decimal RealisedProfitPercentOnCost { get; set; }
        public decimal RealisedProfitPercentOnRev { get; set; }
        public decimal RealisedProfitValue { get; set; }
        public decimal RealisedQuantity { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SoporderProfitAnalysis SoporderProfitAnalysis { get; set; } = null!;
        public virtual SoporderReturnLine SoporderReturnLine { get; set; } = null!;
    }
}
