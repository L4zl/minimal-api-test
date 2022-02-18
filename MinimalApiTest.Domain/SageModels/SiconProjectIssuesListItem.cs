using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectIssuesListItem
    {
        public long SiconProjectIssuesListItemId { get; set; }
        public long? SiconProjectIssuesListId { get; set; }
        public int? IssueNumber { get; set; }
        public string? Product { get; set; }
        public string? Area { get; set; }
        public long? SiconCrmpersonId { get; set; }
        public string? Scenario { get; set; }
        public string? IssueDescription { get; set; }
        public string? IssueType { get; set; }
        public string? Severity { get; set; }
        public DateTime? RequiredByDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CompletedDateTime { get; set; }
        public string? ProjectListType { get; set; }
        public string? CreatedByUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public long? AssignedToEmployeeId { get; set; }
        public string? AssignedToEmployeeName { get; set; }
        public decimal? Pccomplete { get; set; }
        public long? SiconProjectItemGroupId { get; set; }
        public long? SiconProjectItemSectionId { get; set; }
        public long? SiconProjectItemSubSectionId { get; set; }
    }
}
