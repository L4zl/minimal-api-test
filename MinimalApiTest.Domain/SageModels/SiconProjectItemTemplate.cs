using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectItemTemplate
    {
        public long SiconProjectItemTemplateId { get; set; }
        public string? ItemName { get; set; }
        public string? Scenario { get; set; }
        public string? IssueDescription { get; set; }
        public string? IssueType { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
