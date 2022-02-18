using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRamssummary
    {
        public long SiconRamssummaryId { get; set; }
        public long? ParentId { get; set; }
        public string? Summary { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
