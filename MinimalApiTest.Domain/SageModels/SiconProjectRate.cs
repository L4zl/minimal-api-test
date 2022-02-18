using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectRate
    {
        public long SiconProjectRateId { get; set; }
        public long? ParentId { get; set; }
        public string? ParentType { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public string? RateType { get; set; }
        public int? RateIndex { get; set; }
        public string? Description { get; set; }
        public decimal? HourlyRate { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedUserId { get; set; }
    }
}
