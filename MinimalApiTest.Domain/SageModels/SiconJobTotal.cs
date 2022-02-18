using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobTotal
    {
        public long SiconJobTotalId { get; set; }
        public long? SiJcJobId { get; set; }
        public decimal? CostCommittedTotal { get; set; }
        public decimal? RevenueCommittedTotal { get; set; }
        public decimal? CostActualTotal { get; set; }
        public decimal? RevenueActualTotal { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
    }
}
