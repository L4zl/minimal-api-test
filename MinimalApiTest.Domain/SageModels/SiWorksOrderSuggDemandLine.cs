using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderSuggDemandLine
    {
        public long SiWorksOrderSuggDemandLineId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public long? WarehouseId { get; set; }
        public long? ForSuggWoid { get; set; }
        public bool? IsSubAssembly { get; set; }
        public string? InOut { get; set; }
        public bool? MinStockLevel { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
