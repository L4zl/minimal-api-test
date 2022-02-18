using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectIssueComment
    {
        public long SiconProjectIssueCommentId { get; set; }
        public long? SiconProjectIssuesListId { get; set; }
        public long? SiconProjectIssuesListItemId { get; set; }
        public string? Action { get; set; }
        public DateTime? ActionDate { get; set; }
        public long? SiconEmployeeId { get; set; }
        public string? Comment { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
