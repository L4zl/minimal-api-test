using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopIssue
    {
        public WopIssue()
        {
            WopBuildComponentIssueLinks = new HashSet<WopBuildComponentIssueLink>();
            WopIssueShortfalls = new HashSet<WopIssueShortfall>();
            WopTraceableIssues = new HashSet<WopTraceableIssue>();
        }

        public long WopIssueId { get; set; }
        public long? WopComponentLineId { get; set; }
        public long BinItem { get; set; }
        public DateTime IssueDateTime { get; set; }
        public string IssueBy { get; set; } = null!;
        public decimal Quantity { get; set; }
        public long UnitId { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public decimal Cost { get; set; }
        public long DebitNominalAccountId { get; set; }
        public string DebitNominalAccountNumber { get; set; } = null!;
        public string DebitNominalAccountCostCentre { get; set; } = null!;
        public string DebitNominalAccountDepartment { get; set; } = null!;
        public long CreditNominalAccountId { get; set; }
        public string CreditNominalAccountNumber { get; set; } = null!;
        public string CreditNominalAccountCostCentre { get; set; } = null!;
        public string CreditNominalAccountDepartment { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal? ReversedQuantity { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopComponentLine? WopComponentLine { get; set; }
        public virtual ICollection<WopBuildComponentIssueLink> WopBuildComponentIssueLinks { get; set; }
        public virtual ICollection<WopIssueShortfall> WopIssueShortfalls { get; set; }
        public virtual ICollection<WopTraceableIssue> WopTraceableIssues { get; set; }
    }
}
