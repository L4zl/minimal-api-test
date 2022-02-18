using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWolineCanPreallocateView
    {
        public string ItemCode { get; set; } = null!;
        public string? DocumentNo { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public decimal? Quantity { get; set; }
        public long? WarehouseId { get; set; }
        public bool? Deleted { get; set; }
    }
}
