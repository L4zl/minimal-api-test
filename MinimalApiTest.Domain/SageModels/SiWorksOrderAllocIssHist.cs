using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderAllocIssHist
    {
        public long SiWorksOrderAllocIssHistId { get; set; }
        public long? IssueTransactionHistoryId { get; set; }
        public long? SiWorksOrderAllocationLineId { get; set; }
    }
}
