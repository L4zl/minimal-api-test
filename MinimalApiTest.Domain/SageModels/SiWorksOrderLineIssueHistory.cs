using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderLineIssueHistory
    {
        public long SiWorksOrderLineIssueHistoryId { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public long? IssueTransactionHistoryId { get; set; }
        public decimal? IssuedQuantity { get; set; }
        public bool? UnconfirmedCost { get; set; }
        public DateTime? IssueDate { get; set; }
        public bool? Deleted { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? NlnominalAccountId { get; set; }
    }
}
