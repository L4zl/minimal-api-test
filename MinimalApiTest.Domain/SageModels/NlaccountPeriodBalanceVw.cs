using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlaccountPeriodBalanceVw
    {
        public decimal ActualValue { get; set; }
        public string? AccountNumber { get; set; }
        public long SysaccountingPeriodId { get; set; }
    }
}
