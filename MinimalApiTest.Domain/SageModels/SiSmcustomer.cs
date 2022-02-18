using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcustomer
    {
        public long SiSmcustomerId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? SiconContractCoverTypeId { get; set; }
        public bool? PartsIncludedOnContract { get; set; }
        public bool? LabourIncludedOnContract { get; set; }
        public bool? TravelIncludedOnContract { get; set; }
        public decimal? TravelHoursIncludedOnContract { get; set; }
        public decimal? LabourDiscountPercOnContract { get; set; }
        public decimal? LabourHoursIncludedOnContract { get; set; }
        public decimal? PartsDiscountPercentOnContract { get; set; }
        public decimal? CalloutCharge { get; set; }
        public long? SiSmslaid { get; set; }
        public long? TimeRounding { get; set; }
        public decimal? MaxSellingValue { get; set; }
        public long? SiSmpriorityId { get; set; }
        public long? DefaultSiJcJobId { get; set; }
        public decimal? SubsequentCalloutCharge { get; set; }
        public decimal? FirstHourRate { get; set; }
        public decimal? SubsequentHourRate { get; set; }
        public bool? OverrideLabourRates { get; set; }
        public decimal? FixedPriceValue { get; set; }
        public bool? UseFixedPrice { get; set; }
        public long? FixedPriceStockItemId { get; set; }
        public bool? ExpensesIncluded { get; set; }
        public decimal? ExpenseMarkup { get; set; }
        public decimal? MaxTravelChargeHours { get; set; }
        public bool? HalfHourPeriodForLabOverride { get; set; }
        public long? WorkPatternOverrideId { get; set; }
        public decimal? MileageChargeRate { get; set; }
    }
}
