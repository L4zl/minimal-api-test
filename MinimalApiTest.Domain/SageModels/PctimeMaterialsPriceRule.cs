using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PctimeMaterialsPriceRule
    {
        public PctimeMaterialsPriceRule()
        {
            PccostItemOtherCostsPricingRules = new HashSet<PccostItem>();
            PccostItemStockIssuesPricingRules = new HashSet<PccostItem>();
            PccostItemTimesheetPricingRules = new HashSet<PccostItem>();
            PccostItemTypeOtherCostsPricingRules = new HashSet<PccostItemType>();
            PccostItemTypeStockIssuesPricingRules = new HashSet<PccostItemType>();
            PccostItemTypeTimesheetPricingRules = new HashSet<PccostItemType>();
            PcprojectItemOtherCostPricingRules = new HashSet<PcprojectItem>();
            PcprojectItemStockPricingRules = new HashSet<PcprojectItem>();
            PcprojectItemTimePricingRules = new HashSet<PcprojectItem>();
            TschgRateTypePriceModLinks = new HashSet<TschgRateTypePriceModLink>();
        }

        public long PctimeMaterialsPriceRuleId { get; set; }
        public string RuleName { get; set; } = null!;
        public long PcpricingRuleMethodTypeId { get; set; }
        public decimal Amount { get; set; }
        public bool? IsStock { get; set; }
        public bool? IsLabour { get; set; }
        public bool? IsOther { get; set; }
        public long PcpriceModifierTypeId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcpriceModifierType PcpriceModifierType { get; set; } = null!;
        public virtual PcpricingRuleMethodType PcpricingRuleMethodType { get; set; } = null!;
        public virtual ICollection<PccostItem> PccostItemOtherCostsPricingRules { get; set; }
        public virtual ICollection<PccostItem> PccostItemStockIssuesPricingRules { get; set; }
        public virtual ICollection<PccostItem> PccostItemTimesheetPricingRules { get; set; }
        public virtual ICollection<PccostItemType> PccostItemTypeOtherCostsPricingRules { get; set; }
        public virtual ICollection<PccostItemType> PccostItemTypeStockIssuesPricingRules { get; set; }
        public virtual ICollection<PccostItemType> PccostItemTypeTimesheetPricingRules { get; set; }
        public virtual ICollection<PcprojectItem> PcprojectItemOtherCostPricingRules { get; set; }
        public virtual ICollection<PcprojectItem> PcprojectItemStockPricingRules { get; set; }
        public virtual ICollection<PcprojectItem> PcprojectItemTimePricingRules { get; set; }
        public virtual ICollection<TschgRateTypePriceModLink> TschgRateTypePriceModLinks { get; set; }
    }
}
