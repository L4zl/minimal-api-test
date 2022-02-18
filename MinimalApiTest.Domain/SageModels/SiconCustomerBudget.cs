using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCustomerBudget
    {
        public long SiconCustomerBudgetId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public int? PeriodYear { get; set; }
        public int? PeriodNumber { get; set; }
        public decimal? BudgetValue { get; set; }
        public decimal? TargetValue { get; set; }
        public string? DurationType { get; set; }
        public DateTime? DurationStartDate { get; set; }
        public decimal? DurationValue { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public string? LastImportedByUserId { get; set; }
        public DateTime? LastImportedDateTime { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
