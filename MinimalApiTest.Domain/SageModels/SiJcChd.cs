using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcChd
    {
        public long SiJcChdId { get; set; }
        public string? CostCode { get; set; }
        public string? CostCodeType { get; set; }
        public string? Description { get; set; }
        public string? NlnominalAccountId { get; set; }
        public decimal? RepOrder { get; set; }
        public string? RepUse { get; set; }
        public decimal? DefaultPercentageMarkup { get; set; }
        public string? HeaderType { get; set; }
        public long? JobItemTypeId { get; set; }
        public string? JobItemTypeCode { get; set; }
        public long? DefaultFreeTextNlacid { get; set; }
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
        public string? Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public decimal? DefaultCostRate { get; set; }
        public decimal? DefaultHoursRate { get; set; }
        public bool? Inactive { get; set; }
        public int? DefaultRateNumber { get; set; }
        public string? DefaultRateDescription { get; set; }
        public long? AccrualNominalAccountId { get; set; }
        public long? DeferredNominalAccountId { get; set; }
    }
}
