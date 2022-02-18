using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiNlforecastBudget
    {
        public long SiNlforecastBudgetId { get; set; }
        public long NlnominalAccountId { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public short PeriodNumber { get; set; }
        public decimal Value { get; set; }
    }
}
