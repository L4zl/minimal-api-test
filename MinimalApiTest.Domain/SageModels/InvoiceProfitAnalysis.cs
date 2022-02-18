using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InvoiceProfitAnalysis
    {
        public InvoiceProfitAnalysis()
        {
            InvoiceLineProfitAnalyses = new HashSet<InvoiceLineProfitAnalysis>();
        }

        public long InvoiceProfitAnalysisId { get; set; }
        public long SopinvoiceCreditId { get; set; }
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
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SopinvoiceCredit SopinvoiceCredit { get; set; } = null!;
        public virtual ICollection<InvoiceLineProfitAnalysis> InvoiceLineProfitAnalyses { get; set; }
    }
}
