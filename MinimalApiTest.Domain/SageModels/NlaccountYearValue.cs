using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlaccountYearValue
    {
        public NlaccountYearValue()
        {
            NlaccountPeriodValues = new HashSet<NlaccountPeriodValue>();
        }

        public long NlaccountYearValueId { get; set; }
        public long SysfinancialYearId { get; set; }
        public long NlnominalAccountId { get; set; }
        public long NlannualBudgetTypeId { get; set; }
        public long? NlannualBudgetApportProfileId { get; set; }
        public decimal BudgetValue { get; set; }
        public decimal ClosingBalance { get; set; }
        public decimal AdjustmentAfterYearEndClose { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public decimal OriginalBudgetValue { get; set; }

        public virtual NlannualBudgetApportProfile? NlannualBudgetApportProfile { get; set; }
        public virtual NlannualBudgetType NlannualBudgetType { get; set; } = null!;
        public virtual NlnominalAccount NlnominalAccount { get; set; } = null!;
        public virtual SysfinancialYear SysfinancialYear { get; set; } = null!;
        public virtual ICollection<NlaccountPeriodValue> NlaccountPeriodValues { get; set; }
    }
}
