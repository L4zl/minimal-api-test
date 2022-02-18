using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmtransfer
    {
        public long SiconHmtransferId { get; set; }
        public string? HireTransferNumber { get; set; }
        public long? SourceWarehouseId { get; set; }
        public long? TargetWarehouseId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UserName { get; set; }
        public long? StatusId { get; set; }
        public string? Description { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
