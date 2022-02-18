using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlpendNominalAccount
    {
        public NlpendNominalAccount()
        {
            NlpendLastYearPeriodValues = new HashSet<NlpendLastYearPeriodValue>();
            NlpendNominalAccountAnalyses = new HashSet<NlpendNominalAccountAnalysis>();
            NlpendNominalPeriodValues = new HashSet<NlpendNominalPeriodValue>();
            NlpendNominalYearValues = new HashSet<NlpendNominalYearValue>();
        }

        public long NlpendNominalAccountId { get; set; }
        public long NlpendNominalAccountTypeId { get; set; }
        public long NlaccountTypeId { get; set; }
        public string AccountReportCategory { get; set; } = null!;
        public string? ConsolidatedAccountNumber { get; set; }
        public string? ConsolidatedCostCentre { get; set; }
        public string? ConsolidatedDepartment { get; set; }
        public string AccountName { get; set; } = null!;
        public string? AccountNumber { get; set; }
        public string? AccountCostCentre { get; set; }
        public string? AccountDepartment { get; set; }
        public int PeriodsToKeepTransactions { get; set; }
        public bool? AllowJournalsToBePosted { get; set; }
        public bool DisplayBalancesInSelectionList { get; set; }
        public bool PostBatchTotalsOnly { get; set; }
        public decimal CreditYearToDate { get; set; }
        public decimal DebitYearToDate { get; set; }
        public decimal BroughtForwardBalance { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string AccountSofaCategory { get; set; } = null!;
        public long SysaccountStatusId { get; set; }

        public virtual NlaccountType NlaccountType { get; set; } = null!;
        public virtual NlpendNominalAccountType NlpendNominalAccountType { get; set; } = null!;
        public virtual SysaccountStatus SysaccountStatus { get; set; } = null!;
        public virtual ICollection<NlpendLastYearPeriodValue> NlpendLastYearPeriodValues { get; set; }
        public virtual ICollection<NlpendNominalAccountAnalysis> NlpendNominalAccountAnalyses { get; set; }
        public virtual ICollection<NlpendNominalPeriodValue> NlpendNominalPeriodValues { get; set; }
        public virtual ICollection<NlpendNominalYearValue> NlpendNominalYearValues { get; set; }
    }
}
