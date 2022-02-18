using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PccostItem
    {
        public PccostItem()
        {
            Blclauses = new HashSet<Blclause>();
            PccostItemAnalysisFields = new HashSet<PccostItemAnalysisField>();
            PcprojectItems = new HashSet<PcprojectItem>();
        }

        public long PccostItemId { get; set; }
        public long CostItemTypeId { get; set; }
        public long CostPcunitOfMeasureId { get; set; }
        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool AvailableForSelection { get; set; }
        public decimal BudgetCostQuantity { get; set; }
        public decimal BudgetCostValue { get; set; }
        public decimal BudgetRevenueQuantity { get; set; }
        public decimal BudgetRevenueValue { get; set; }
        public decimal UnitCost { get; set; }
        public decimal? UpliftRateValue { get; set; }
        public decimal? UpliftRatePercentage { get; set; }
        public decimal MarkUpPercentage { get; set; }
        public decimal BillRate { get; set; }
        public string? DefaultExpenseNominalAccountNumber { get; set; }
        public string? DefaultExpenseNominalCostCentre { get; set; }
        public string? DefaultExpenseNominalDepartment { get; set; }
        public string? DefaultRevenueNominalAccountNumber { get; set; }
        public string? DefaultRevenueNominalCostCentre { get; set; }
        public string? DefaultRevenueNominalDepartment { get; set; }
        public long TimesheetPricingRuleId { get; set; }
        public long StockIssuesPricingRuleId { get; set; }
        public long OtherCostsPricingRuleId { get; set; }
        public string? OverheadNominalAccountNumber { get; set; }
        public string? OverheadNominalCostCentre { get; set; }
        public string? OverheadNominalDepartment { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public bool UseWipspecificNominalAccount { get; set; }
        public string? DefaultWipnominalAccountNumber { get; set; }
        public string? DefaultWipnominalCostCentre { get; set; }
        public string? DefaultWipnominalDepartment { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PccostItemType CostItemType { get; set; } = null!;
        public virtual PcunitOfMeasure CostPcunitOfMeasure { get; set; } = null!;
        public virtual PctimeMaterialsPriceRule OtherCostsPricingRule { get; set; } = null!;
        public virtual PctimeMaterialsPriceRule StockIssuesPricingRule { get; set; } = null!;
        public virtual PctimeMaterialsPriceRule TimesheetPricingRule { get; set; } = null!;
        public virtual ICollection<Blclause> Blclauses { get; set; }
        public virtual ICollection<PccostItemAnalysisField> PccostItemAnalysisFields { get; set; }
        public virtual ICollection<PcprojectItem> PcprojectItems { get; set; }
    }
}
