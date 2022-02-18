using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWobudgetActualSummaryView
    {
        public long? SiWorksOrderId { get; set; }
        public long? ItemId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? SoporderReturnId { get; set; }
        public string? Wonumber { get; set; }
        public string? Woname { get; set; }
        public decimal TotalComponentBudgetCost { get; set; }
        public decimal TotalComponentActualCost { get; set; }
        public decimal TotalNonStockBudgetCost { get; set; }
        public decimal TotalNonStockActualCost { get; set; }
        public decimal TotalLabourBudgetCost { get; set; }
        public decimal TotalLabourActualCost { get; set; }
        public decimal TotalMachineBudgetCost { get; set; }
        public decimal TotalMachineActualCost { get; set; }
        public decimal TotalSubContractBudgetCost { get; set; }
        public decimal TotalSubContractActualCost { get; set; }
        public decimal? TotalOverheadBudgetCost { get; set; }
        public decimal? TotalOverheadActualCost { get; set; }
    }
}
