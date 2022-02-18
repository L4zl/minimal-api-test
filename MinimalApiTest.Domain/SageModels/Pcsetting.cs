using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Pcsetting
    {
        public long PcsettingId { get; set; }
        public bool UseProjectBudgeting { get; set; }
        public bool UseCostBudgets { get; set; }
        public bool UseRevenueBudgets { get; set; }
        public long PcbudgetLevelId { get; set; }
        public bool UseOverheadAbsorption { get; set; }
        public bool UseProjectSpecificOverheadUpliftRates { get; set; }
        public bool UseSubcontractorSupplierManagement { get; set; }
        public bool UseCommittedCostsAndAccruals { get; set; }
        public string AccrualsNominalAccountNumber { get; set; } = null!;
        public string AccrualsNominalAccountCostCentre { get; set; } = null!;
        public string AccrualsNominalAccountDepartment { get; set; } = null!;
        public bool BillCommittedAccruedCosts { get; set; }
        public bool AutoGenerateProjectCodes { get; set; }
        public bool DisplayProjectStructures { get; set; }
        public long PccreateProjectPreferenceId { get; set; }
        public bool ValueToBillCanBeAmended { get; set; }
        public bool UsePostOverheadAbsorption { get; set; }
        public bool CombineLinesOnSingleInvoice { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public bool? PostPaymentAsCostElseRevenue { get; set; }
        public bool? PostReceiptAsCostElseRevenue { get; set; }
        public string HierarchySeparator { get; set; } = null!;
        public bool UseSopforRevenueNominal { get; set; }
        public bool UseSopforCostNominal { get; set; }
        public bool UseWip { get; set; }
        public bool UseWipspecificNominalAccount { get; set; }
        public string WipnominalAccountNumber { get; set; } = null!;
        public string WipnominalCostCentre { get; set; } = null!;
        public string WipnominalDepartment { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcbudgetLevel PcbudgetLevel { get; set; } = null!;
        public virtual PccreateProjectPreference PccreateProjectPreference { get; set; } = null!;
    }
}
