using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmtransferItem
    {
        public long SiconHmtransferItemId { get; set; }
        public long? SiconHmtransferId { get; set; }
        public long? FixedAssetId { get; set; }
        public int? RequiredQuantity { get; set; }
        public int? DespatchedQuantity { get; set; }
        public int? ReceivedQuantity { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
