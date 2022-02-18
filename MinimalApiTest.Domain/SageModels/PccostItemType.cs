using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PccostItemType
    {
        public PccostItemType()
        {
            Blclauses = new HashSet<Blclause>();
            PccostItemTypeAnalFieldSettings = new HashSet<PccostItemTypeAnalFieldSetting>();
            PccostItemTypeFeatureSettings = new HashSet<PccostItemTypeFeatureSetting>();
            PccostItemTypeIntegrateSettings = new HashSet<PccostItemTypeIntegrateSetting>();
            PccostItems = new HashSet<PccostItem>();
        }

        public long PccostItemTypeId { get; set; }
        public string Title { get; set; } = null!;
        public long? DefaultCostPcunitOfMeasureId { get; set; }
        public string? DefaultExpenseNominalAccountNumber { get; set; }
        public string? DefaultExpenseNominalCostCentre { get; set; }
        public string? DefaultExpenseNominalDepartment { get; set; }
        public string? DefaultRevenueNominalAccountNumber { get; set; }
        public string? DefaultRevenueNominalCostCentre { get; set; }
        public string? DefaultRevenueNominalDepartment { get; set; }
        public long PcoverheadUpliftRateModifierId { get; set; }
        public decimal? OverheadUpliftRateValue { get; set; }
        public decimal? OverheadUpliftRatePercentage { get; set; }
        public long PcprojectItemStatusId { get; set; }
        public bool? IsOverhead { get; set; }
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

        public virtual PcunitOfMeasure? DefaultCostPcunitOfMeasure { get; set; }
        public virtual PctimeMaterialsPriceRule OtherCostsPricingRule { get; set; } = null!;
        public virtual PcoverheadUpliftRateModifier PcoverheadUpliftRateModifier { get; set; } = null!;
        public virtual PcprojectItemStatus PcprojectItemStatus { get; set; } = null!;
        public virtual PctimeMaterialsPriceRule StockIssuesPricingRule { get; set; } = null!;
        public virtual PctimeMaterialsPriceRule TimesheetPricingRule { get; set; } = null!;
        public virtual ICollection<Blclause> Blclauses { get; set; }
        public virtual ICollection<PccostItemTypeAnalFieldSetting> PccostItemTypeAnalFieldSettings { get; set; }
        public virtual ICollection<PccostItemTypeFeatureSetting> PccostItemTypeFeatureSettings { get; set; }
        public virtual ICollection<PccostItemTypeIntegrateSetting> PccostItemTypeIntegrateSettings { get; set; }
        public virtual ICollection<PccostItem> PccostItems { get; set; }
    }
}
