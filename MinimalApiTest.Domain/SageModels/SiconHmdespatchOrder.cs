using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmdespatchOrder
    {
        public long SiconHmdespatchOrderId { get; set; }
        public long SiconHmdespatchId { get; set; }
        public long SiconHmorderId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
