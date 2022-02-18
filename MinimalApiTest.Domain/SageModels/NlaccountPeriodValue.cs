using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlaccountPeriodValue
    {
        public long NlaccountPeriodValueId { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public long NlnominalAccountId { get; set; }
        public long NlaccountYearValueId { get; set; }
        public decimal? PercentageOfAnnualBudget { get; set; }
        public decimal BudgetValue { get; set; }
        public decimal ActualValue { get; set; }
        public decimal AdjustmentAfterYearEndClose { get; set; }
        public decimal ConsolidatedAmount { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public decimal OriginalBudgetValue { get; set; }

        public virtual NlaccountYearValue NlaccountYearValue { get; set; } = null!;
        public virtual NlnominalAccount NlnominalAccount { get; set; } = null!;
        public virtual SysaccountingPeriod SysaccountingPeriod { get; set; } = null!;
    }
}
