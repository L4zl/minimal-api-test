using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcBudHistory
    {
        public long SiJcBudHistoryId { get; set; }
        public long? SiJcBudId { get; set; }
        public decimal? PreviousBudgetAmount { get; set; }
        public decimal? NewBudgetAmount { get; set; }
        public decimal? Variance { get; set; }
        public string? ReasonForChange { get; set; }
        public long? SiJcVariationId { get; set; }
        public DateTime? BudgetChangedDateTime { get; set; }
        public string? BudgetChangedByUserId { get; set; }
    }
}
