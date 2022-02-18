using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SijobStage
    {
        public long SijobStageId { get; set; }
        public long? SijobPhaseId { get; set; }
        public int? StageSequence { get; set; }
        public string? StageDescription { get; set; }
        public long? StageStatus { get; set; }
        public string? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? FreeTextDescription { get; set; }
        public decimal? QuotePrice { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? PercentCompleted { get; set; }
    }
}
