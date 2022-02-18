using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiNlextraBudget
    {
        public long SiNlextraBudgetId { get; set; }
        public long NlnominalAccountId { get; set; }
        public string? BudgetType { get; set; }
        public int? PeriodNumber { get; set; }
        public double? BudgetValue { get; set; }
        public double? ActualValue { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public double? SpareNumber1 { get; set; }
        public double? SpareNumber2 { get; set; }
        public double? SpareNumber3 { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public string? LastImportedByUserId { get; set; }
        public DateTime? LastImportedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
