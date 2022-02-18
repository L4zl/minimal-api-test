using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiNextNumber
    {
        public long SiNextNumberId { get; set; }
        public string NextNumberKey { get; set; } = null!;
        public long CurrentValue { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
