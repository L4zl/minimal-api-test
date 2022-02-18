using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectIssuesList
    {
        public long SiconProjectIssuesListId { get; set; }
        public long? SiJcJobId { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
