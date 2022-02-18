using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlreportCategoryBudgetYearValue
    {
        public long NlreportCategoryBudgetYearValueId { get; set; }
        public long NlreportCategoryBudgetId { get; set; }
        public long SysfinancialYearId { get; set; }
        public decimal BudgetValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlreportCategoryBudget NlreportCategoryBudget { get; set; } = null!;
        public virtual SysfinancialYear SysfinancialYear { get; set; } = null!;
    }
}
