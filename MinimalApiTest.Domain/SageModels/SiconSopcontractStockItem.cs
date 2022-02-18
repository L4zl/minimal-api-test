using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSopcontractStockItem
    {
        public long SiconSopcontractStockItemId { get; set; }
        public long? ItemId { get; set; }
        public bool? IsContracted { get; set; }
        public bool? IsDeferred { get; set; }
        public bool? IsRevenueDeferred { get; set; }
        public bool? IsCostDeferred { get; set; }
        public bool? MaintainableItem { get; set; }
        public bool? VariableBilling { get; set; }
        public bool? NewContractForEachSo { get; set; }
        public bool? NewContractLineForEachSo { get; set; }
        public long? ContractItemId { get; set; }
        public decimal? DefaultCharge { get; set; }
        public long? NlrevenueNominalCodeId { get; set; }
        public long? NldeferredRevenueNominalCodeId { get; set; }
        public long? NlbsdeferredCostNominalCodeId { get; set; }
        public long? NlplcostNominalCodeId { get; set; }
        public int? DeferredPostingDuration { get; set; }
        public string? DefaultLineDescription { get; set; }
        public string? DefaultInternalDescription { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
