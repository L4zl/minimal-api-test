using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRetentionJcjobList
    {
        public long SiconRetentionJcjobListId { get; set; }
        public long SiconRetentionId { get; set; }
        public long SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long SiJcTrnId { get; set; }
        public decimal? RetentionNetValue { get; set; }
        public decimal? RetentionTaxValue { get; set; }
        public decimal? OutstandingValueNetPos { get; set; }
        public decimal? OutstandingValuePos { get; set; }
        public bool? Released { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public decimal? ReleasedValueNet { get; set; }
        public decimal? ReleasedValue { get; set; }
        public decimal? ReleasedValueNetPos { get; set; }
        public decimal? ReleasedValuePos { get; set; }
        public bool? WriteOff { get; set; }
    }
}
