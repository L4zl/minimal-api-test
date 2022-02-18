using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabtransfer
    {
        public long SiconWabtransferId { get; set; }
        public long SourceWarehouseId { get; set; }
        public string TransferNumber { get; set; } = null!;
        public DateTime? TransferCreatedDate { get; set; }
        public string Username { get; set; } = null!;
        public long StatusId { get; set; }
        public long TransferTypeId { get; set; }
    }
}
