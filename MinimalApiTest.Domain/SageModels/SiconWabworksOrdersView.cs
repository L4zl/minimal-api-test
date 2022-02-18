using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabworksOrdersView
    {
        public long SiWorksOrderId { get; set; }
        public long? WarehouseId { get; set; }
        public DateTime? WodueDate { get; set; }
        public string? Wonumber { get; set; }
        public int? Picking { get; set; }
        public string? Wostatus { get; set; }
    }
}
