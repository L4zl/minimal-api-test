using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseReadyForBillView
    {
        public long SiSmcaseId { get; set; }
        public string? CaseNumber { get; set; }
        public int? BillingPlan { get; set; }
        public bool? ExpensesIncluded { get; set; }
    }
}
