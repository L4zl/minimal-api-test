using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectIssueOperation
    {
        public long SiconProjectIssueOperationId { get; set; }
        public long? SiconProjectIssuesListItemId { get; set; }
        public long? SiOperationHeaderId { get; set; }
    }
}
