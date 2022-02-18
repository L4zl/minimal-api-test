using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InvoiceLineProfitAnalysis
    {
        public long InvoiceLineProfitAnalysisId { get; set; }
        public long InvoiceProfitAnalysisId { get; set; }
        public long SopinvoiceCreditLineId { get; set; }
        public decimal EstimatedCostValue { get; set; }
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

        public virtual InvoiceProfitAnalysis InvoiceProfitAnalysis { get; set; } = null!;
        public virtual SopinvoiceCreditLine SopinvoiceCreditLine { get; set; } = null!;
    }
}
