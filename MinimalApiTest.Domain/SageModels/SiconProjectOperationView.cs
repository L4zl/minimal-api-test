using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectOperationView
    {
        public long SiOperationHeaderId { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? SijobPhaseId { get; set; }
        public string? PhaseDescription { get; set; }
        public long? SijobStageId { get; set; }
        public string? StageDescription { get; set; }
        public long? SijobActivityId { get; set; }
        public string? ActivityDescription { get; set; }
        public string? Id { get; set; }
        public string? Description { get; set; }
        public string? ThirdPartyReference { get; set; }
        public string? Comment { get; set; }
        public string? Status { get; set; }
        public decimal? Pccomplete { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public long? SiconTeamId { get; set; }
        public string? Team { get; set; }
        public decimal? Hours { get; set; }
        public decimal? ExpectedHours { get; set; }
        public decimal ActualHours { get; set; }
        public decimal? RemainingHours { get; set; }
        public decimal? ManningLevel { get; set; }
        public string? AssignedToUser { get; set; }
        public string? JobManager { get; set; }
    }
}
