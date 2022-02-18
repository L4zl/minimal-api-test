using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlbudgetApportPeriodPrcnt
    {
        public long NlbudgetApportPeriodPrcntId { get; set; }
        public long NlannualBudgetApportProfileId { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public decimal PercentageOfAnnualBudget { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlannualBudgetApportProfile NlannualBudgetApportProfile { get; set; } = null!;
        public virtual SysaccountingPeriod SysaccountingPeriod { get; set; } = null!;
    }
}
