using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWowipview
    {
        public long SiWorksOrderId { get; set; }
        public string? Wonumber { get; set; }
        public DateTime? WocreatedDate { get; set; }
        public string? Wostatus { get; set; }
        public decimal TotalComponentBudgetCost { get; set; }
        public decimal TotalComponentActualCosts { get; set; }
        public decimal TotalLabourBudgetCosts { get; set; }
        public decimal TotalLabourActualCosts { get; set; }
        public decimal TotalMachineBudgetCosts { get; set; }
        public decimal TotalMachineActualCosts { get; set; }
        public decimal TotalSubContractBudgetCosts { get; set; }
        public decimal TotalSubContractActualCosts { get; set; }
        public decimal TotalBookedInCosts { get; set; }
    }
}
