using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmnominalCashBudget
    {
        public long SiconCfmnominalCashBudgetId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? NlaccountPeriodValueId { get; set; }
        public long? NlaccountYearValueId { get; set; }
        public decimal CashBudget { get; set; }
        public bool Paid { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Deleted { get; set; }
    }
}
