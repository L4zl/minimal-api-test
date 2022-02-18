using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistMarkUp
    {
        public long SiconDistMarkUpId { get; set; }
        public long? CustomerId { get; set; }
        public long? ProductGroupId { get; set; }
        public bool IncludeLandedCost { get; set; }
        public bool UseMarkUp { get; set; }
        public decimal? MarkUpPercent { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
