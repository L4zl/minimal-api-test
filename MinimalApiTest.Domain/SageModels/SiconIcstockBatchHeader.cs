using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcstockBatchHeader
    {
        public long SiconIcstockBatchHeaderId { get; set; }
        public string CompanyFrom { get; set; } = null!;
        public string CompanyTo { get; set; } = null!;
        public string BatchHeader { get; set; } = null!;
        public DateTime? EstimatedTransferDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public long AllocationUrn { get; set; }
        public long InternalArea { get; set; }
        public string BatchStatus { get; set; } = null!;
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
        public int CompanyToNo { get; set; }
        public int CompanyFromNo { get; set; }
    }
}
