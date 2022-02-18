using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistAllocationDetailsView
    {
        public long ItemId { get; set; }
        public long WarehouseItemId { get; set; }
        public string EntrySourceName { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string RecipientName { get; set; } = null!;
        public string? DocumentStatus { get; set; }
        public DateTime? RequestedDelDate { get; set; }
        public DateTime? PromisedDelDate { get; set; }
        public decimal AllocatedQuantity { get; set; }
    }
}
