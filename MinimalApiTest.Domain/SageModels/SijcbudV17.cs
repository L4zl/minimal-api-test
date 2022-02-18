using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SijcbudV17
    {
        public long SiJcBudId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public DateTime? BudgetDateFrom { get; set; }
        public DateTime? BudgetDateTo { get; set; }
        public string? BudgetType { get; set; }
        public decimal? BudgetAmount { get; set; }
        public decimal? BudgetActualAmount { get; set; }
        public decimal? BudgetCommittedAmount { get; set; }
        public decimal? BudgetBothAmount { get; set; }
        public string? DepartmentCode { get; set; }
        public string? BudgetDescription { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public string? SpareText6 { get; set; }
        public string? SpareText7 { get; set; }
        public string? SpareText8 { get; set; }
        public string? SpareText9 { get; set; }
        public string? SpareText10 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public decimal? SpareNumber6 { get; set; }
        public decimal? SpareNumber7 { get; set; }
        public decimal? SpareNumber8 { get; set; }
        public decimal? SpareNumber9 { get; set; }
        public decimal? SpareNumber10 { get; set; }
        public string? SpareMemo1 { get; set; }
        public string? SpareMemo2 { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedUser { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? SiJcVariationId { get; set; }
        public decimal? HoursRate { get; set; }
        public decimal? OriginalBudgetAmount { get; set; }
        public decimal? OriginalBudgetHours { get; set; }
        public decimal? PreviousBudgetAmount { get; set; }
        public decimal? PreviousBudgetHours { get; set; }
        public long? RevenueSiJcChdId { get; set; }
        public decimal? MarkUpPercent { get; set; }
        public decimal? MarkUpValue { get; set; }
    }
}
