using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectSubOperationView
    {
        public long SiOperationId { get; set; }
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
        public long? SiconEmployeeId { get; set; }
        public string? Team { get; set; }
        public decimal? Hours { get; set; }
        public string? AssignedToUser { get; set; }
    }
}
