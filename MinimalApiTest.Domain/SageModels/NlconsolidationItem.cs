using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlconsolidationItem
    {
        public long NlconsolidationItemId { get; set; }
        public long NlconsolidationId { get; set; }
        public string AccountName { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;
        public string AccountCostCentre { get; set; } = null!;
        public string AccountDepartment { get; set; } = null!;
        public string ConsolidatedAccountNumber { get; set; } = null!;
        public string ConsolidatedCostCentre { get; set; } = null!;
        public string ConsolidatedDepartment { get; set; } = null!;
        public decimal Amount { get; set; }

        public virtual Nlconsolidation Nlconsolidation { get; set; } = null!;
    }
}
