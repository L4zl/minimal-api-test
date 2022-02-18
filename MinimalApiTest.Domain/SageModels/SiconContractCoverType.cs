using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractCoverType
    {
        public long SiconContractCoverTypeId { get; set; }
        public string? Name { get; set; }
        public bool? PartsIncluded { get; set; }
        public bool? LabourIncluded { get; set; }
        public bool? TravelIncluded { get; set; }
        public decimal? TravelHoursIncluded { get; set; }
        public decimal? LabourDiscountPercent { get; set; }
        public decimal? PartsDiscountPercent { get; set; }
        public decimal? LabourHoursIncluded { get; set; }
        public long? SiSmslaid { get; set; }
        public decimal? FixedPrice { get; set; }
        public long? TimeRounding { get; set; }
        public decimal? CalloutCharge { get; set; }
        public decimal? MaxSellingValue { get; set; }
        public long? SiSmpriorityId { get; set; }
        public decimal? MaxTravelChargeHours { get; set; }
        public bool? HalfHourPeriodForLabOverride { get; set; }
        public decimal? SubsequentCalloutCharge { get; set; }
        public decimal? FirstHourRate { get; set; }
        public decimal? SubsequentHourRate { get; set; }
        public bool? OverrideLabourRates { get; set; }
        public decimal? FixedPriceValue { get; set; }
        public long? FixedPriceStockItemId { get; set; }
        public bool? UseFixedPrice { get; set; }
        public bool? ExpensesIncluded { get; set; }
        public decimal? ExpenseMarkup { get; set; }
        public long? WorkPatternOverrideId { get; set; }
        public decimal? MileageChargeRate { get; set; }
    }
}
