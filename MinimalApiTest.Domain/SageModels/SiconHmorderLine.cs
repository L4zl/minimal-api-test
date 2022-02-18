using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLine
    {
        public long SiconHmorderLineId { get; set; }
        public long SiconHmorderId { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public long? SiconSubLocationId { get; set; }
        public int SequenceNo { get; set; }
        public int? FrequencyValue { get; set; }
        public long? FrequencyTimeUnitId { get; set; }
        public int? DayOfMonth { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? LastGenerationDate { get; set; }
        public long? RepeatOrderTypeId { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TotalRepeatCount { get; set; }
        public int? CurrentRepeatCount { get; set; }
        public DateTime? NextDueDate { get; set; }
        public decimal? LineTotalValue { get; set; }
        public decimal? LineTaxValue { get; set; }
        public string? Description { get; set; }
        public DateTime? RequestedFromDate { get; set; }
        public DateTime? RequestedToDate { get; set; }
        public long? DefaultSellingTimeUnitId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? CollectionDate { get; set; }
        public bool? UndefinedHirePeriod { get; set; }
        public long? WarehouseId { get; set; }
        public bool? OverrideDiscounts { get; set; }
        public decimal? LineDiscount { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public string? AnalysisCode6 { get; set; }
        public string? AnalysisCode7 { get; set; }
        public string? AnalysisCode8 { get; set; }
        public string? AnalysisCode9 { get; set; }
        public string? AnalysisCode10 { get; set; }
        public string? AnalysisCode11 { get; set; }
        public string? AnalysisCode12 { get; set; }
        public string? AnalysisCode13 { get; set; }
        public string? AnalysisCode14 { get; set; }
        public string? AnalysisCode15 { get; set; }
        public string? AnalysisCode16 { get; set; }
        public string? AnalysisCode17 { get; set; }
        public string? AnalysisCode18 { get; set; }
        public string? AnalysisCode19 { get; set; }
        public string? AnalysisCode20 { get; set; }
        public DateTime? FixedBillingDate { get; set; }
        public decimal? FixedBillingValue { get; set; }
        public long? FixedNlnominalAccountId { get; set; }
        public bool? IsCreateDeliveryCase { get; set; }
        public long? DeliverySiSmcaseTypeId { get; set; }
        public long? DeliverySiSmcaseId { get; set; }
        public DateTime? CaseDeliveryDate { get; set; }
        public bool? IsCreateCollectionCase { get; set; }
        public long? CollectionSiSmcaseTypeId { get; set; }
        public long? CollectionSiSmcaseId { get; set; }
        public DateTime? CaseCollectionDate { get; set; }
        public long? LastChangeIncrement { get; set; }
        public long? LastAmendIncrement { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public bool? IsForecastGenerated { get; set; }
    }
}
