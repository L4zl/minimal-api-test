using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistReAllocationLine
    {
        public long? SiconDistReAllocationLineId { get; set; }
        public long? SopreturnId { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
