using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWocanPreallocateView
    {
        public string ItemCode { get; set; } = null!;
        public string? DocumentNo { get; set; }
        public long SiWorksOrderFinishedItemId { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public decimal? Quantity { get; set; }
        public long WarehouseId { get; set; }
    }
}
