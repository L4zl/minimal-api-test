using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabtransferItem
    {
        public long SiconWabtransferItemId { get; set; }
        public long SiconWabtransferId { get; set; }
        public long IntransitBinItemId { get; set; }
        public decimal IntransitQuantity { get; set; }
        public decimal TransferredQuantity { get; set; }
    }
}
