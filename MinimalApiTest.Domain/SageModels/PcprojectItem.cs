using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectItem
    {
        public PcprojectItem()
        {
            BlbillLines = new HashSet<BlbillLine>();
            Blcontracts = new HashSet<Blcontract>();
            InversePcprojectItemParent = new HashSet<PcprojectItem>();
            Pcaccruals = new HashSet<Pcaccrual>();
            PcprojectAuthorisers = new HashSet<PcprojectAuthoriser>();
            PcprojectContacts = new HashSet<PcprojectContact>();
            PcprojectEntries = new HashSet<PcprojectEntry>();
            PcprojectItemAnalysisFields = new HashSet<PcprojectItemAnalysisField>();
            PcprojectItemBudgetHistories = new HashSet<PcprojectItemBudgetHistory>();
            PcprojectItemBudgetPdHistories = new HashSet<PcprojectItemBudgetPdHistory>();
            PcprojectItemBudgetPdValues = new HashSet<PcprojectItemBudgetPdValue>();
            PcprojectItemHierarchyBelongsToPcprojectItems = new HashSet<PcprojectItemHierarchy>();
            PcprojectItemHierarchyPcimmediateParents = new HashSet<PcprojectItemHierarchy>();
            PcprojectItemHierarchyPcprojectItems = new HashSet<PcprojectItemHierarchy>();
            PcprojectItemHierarchyPctopLevelParents = new HashSet<PcprojectItemHierarchy>();
            PcprojectItemMemos = new HashSet<PcprojectItemMemo>();
            PcprojectItemPoporderLines = new HashSet<PcprojectItemPoporderLine>();
            PcprojectItemStatusHistories = new HashSet<PcprojectItemStatusHistory>();
            PcprojectResourceLinks = new HashSet<PcprojectResourceLink>();
            TsclaimRecordActivities = new HashSet<TsclaimRecord>();
            TsclaimRecordParentProjects = new HashSet<TsclaimRecord>();
            TstimeRecordActivities = new HashSet<TstimeRecord>();
            TstimeRecordParentProjects = new HashSet<TstimeRecord>();
        }

        public long PcprojectItemId { get; set; }
        public long? PcprojectItemParentId { get; set; }
        public long PcprojectItemTypeId { get; set; }
        public long? PcprojectLevelId { get; set; }
        public long? PccostGroupId { get; set; }
        public long? PccostItemId { get; set; }
        public long ProjectStatusId { get; set; }
        public long? CostPcunitOfMeasureId { get; set; }
        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public short PercentageComplete { get; set; }
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
        public bool OverrideSubItemCostBudgets { get; set; }
        public bool OverrideSubItemRevenueBudgets { get; set; }
        public long? PcprojectLevelBillingMethodId { get; set; }
        public int Sequence { get; set; }
        public DateTime DateCreated { get; set; }
        public long? TimePricingRuleId { get; set; }
        public long? StockPricingRuleId { get; set; }
        public long? OtherCostPricingRuleId { get; set; }
        public long? DefaultBillTemplateId { get; set; }
        public string? OverheadNominalAccountNumber { get; set; }
        public string? OverheadNominalCostCentre { get; set; }
        public string? OverheadNominalDepartment { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public byte Depth { get; set; }
        public string SortKey { get; set; } = null!;
        public bool AnalyseBudgetsByTradingPeriod { get; set; }
        public long PcprojectArchiveStatusId { get; set; }
        public bool UseWip { get; set; }
        public string? DefaultWipnominalAccountNumber { get; set; }
        public string? DefaultWipnominalCostCentre { get; set; }
        public string? DefaultWipnominalDepartment { get; set; }
        public string? DefaultProjectCostCentre { get; set; }
        public string? DefaultProjectDepartment { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcunitOfMeasure? CostPcunitOfMeasure { get; set; }
        public virtual BlbillTemplate? DefaultBillTemplate { get; set; }
        public virtual PctimeMaterialsPriceRule? OtherCostPricingRule { get; set; }
        public virtual PccostGroup? PccostGroup { get; set; }
        public virtual PccostItem? PccostItem { get; set; }
        public virtual PcprojectArchiveStatus PcprojectArchiveStatus { get; set; } = null!;
        public virtual PcprojectItem? PcprojectItemParent { get; set; }
        public virtual PcprojectItemType PcprojectItemType { get; set; } = null!;
        public virtual PcprojectLevel? PcprojectLevel { get; set; }
        public virtual PcprojectLevelBillingMethod? PcprojectLevelBillingMethod { get; set; }
        public virtual PcprojectItemStatus ProjectStatus { get; set; } = null!;
        public virtual PctimeMaterialsPriceRule? StockPricingRule { get; set; }
        public virtual PctimeMaterialsPriceRule? TimePricingRule { get; set; }
        public virtual ICollection<BlbillLine> BlbillLines { get; set; }
        public virtual ICollection<Blcontract> Blcontracts { get; set; }
        public virtual ICollection<PcprojectItem> InversePcprojectItemParent { get; set; }
        public virtual ICollection<Pcaccrual> Pcaccruals { get; set; }
        public virtual ICollection<PcprojectAuthoriser> PcprojectAuthorisers { get; set; }
        public virtual ICollection<PcprojectContact> PcprojectContacts { get; set; }
        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
        public virtual ICollection<PcprojectItemAnalysisField> PcprojectItemAnalysisFields { get; set; }
        public virtual ICollection<PcprojectItemBudgetHistory> PcprojectItemBudgetHistories { get; set; }
        public virtual ICollection<PcprojectItemBudgetPdHistory> PcprojectItemBudgetPdHistories { get; set; }
        public virtual ICollection<PcprojectItemBudgetPdValue> PcprojectItemBudgetPdValues { get; set; }
        public virtual ICollection<PcprojectItemHierarchy> PcprojectItemHierarchyBelongsToPcprojectItems { get; set; }
        public virtual ICollection<PcprojectItemHierarchy> PcprojectItemHierarchyPcimmediateParents { get; set; }
        public virtual ICollection<PcprojectItemHierarchy> PcprojectItemHierarchyPcprojectItems { get; set; }
        public virtual ICollection<PcprojectItemHierarchy> PcprojectItemHierarchyPctopLevelParents { get; set; }
        public virtual ICollection<PcprojectItemMemo> PcprojectItemMemos { get; set; }
        public virtual ICollection<PcprojectItemPoporderLine> PcprojectItemPoporderLines { get; set; }
        public virtual ICollection<PcprojectItemStatusHistory> PcprojectItemStatusHistories { get; set; }
        public virtual ICollection<PcprojectResourceLink> PcprojectResourceLinks { get; set; }
        public virtual ICollection<TsclaimRecord> TsclaimRecordActivities { get; set; }
        public virtual ICollection<TsclaimRecord> TsclaimRecordParentProjects { get; set; }
        public virtual ICollection<TstimeRecord> TstimeRecordActivities { get; set; }
        public virtual ICollection<TstimeRecord> TstimeRecordParentProjects { get; set; }
    }
}
