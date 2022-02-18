using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmdespatch
    {
        public long SiconHmdespatchId { get; set; }
        public string DespatchRef { get; set; } = null!;
        public DateTime DespatchDate { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
