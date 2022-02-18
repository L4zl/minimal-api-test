using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcustReturnDespatchIssue
    {
        public long SiSmcustReturnDespatchIssueId { get; set; }
        public long SiSmcustReturnDespatchId { get; set; }
        public DateTime? DespatchDate { get; set; }
        public long? IssueHistoryId { get; set; }
        public decimal? Quantity { get; set; }
        public long? CostSiJcTrnId { get; set; }
    }
}
