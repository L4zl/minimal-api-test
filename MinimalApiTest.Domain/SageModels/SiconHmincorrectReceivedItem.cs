using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmincorrectReceivedItem
    {
        public long SiconHmincorrectReceivedItemId { get; set; }
        public long SiconHmorderId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long SiconFixedAssetId { get; set; }
        public decimal QuantityReceived { get; set; }
        public string Description { get; set; } = null!;
        public string LastHireOrderNumber { get; set; } = null!;
        public string ResolvedStatusCode { get; set; } = null!;
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
