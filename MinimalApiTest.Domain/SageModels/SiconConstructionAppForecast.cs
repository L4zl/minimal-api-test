using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppForecast
    {
        public long SiconConstructionAppForecastId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public string? Reference { get; set; }
        public decimal? ForecastValue { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public decimal? OriginalForecastValue { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
