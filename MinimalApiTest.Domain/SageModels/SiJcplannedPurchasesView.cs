using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcplannedPurchasesView
    {
        public long SiJcPlannedPurchaseId { get; set; }
        public long SiJcJobid { get; set; }
        public string? JobNumber { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public long SiJcChdId { get; set; }
        public string? JobHeader { get; set; }
        public string? ItemCode { get; set; }
        public string? StockDescription { get; set; }
        public decimal? TenderQuantity { get; set; }
        public decimal? TenderUnitValue { get; set; }
        public decimal? TenderTotal { get; set; }
        public decimal? RevisedQuantity { get; set; }
        public decimal? RevisedUnitValue { get; set; }
        public decimal? RevisedTotal { get; set; }
        public decimal? ForecastQuantity { get; set; }
        public decimal? ForecastUnitValue { get; set; }
        public decimal? ForecastTotal { get; set; }
        public string? LineStatus { get; set; }
    }
}
