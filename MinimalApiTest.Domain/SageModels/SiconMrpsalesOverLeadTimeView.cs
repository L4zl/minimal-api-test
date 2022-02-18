using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMrpsalesOverLeadTimeView
    {
        public long WarehouseItemId { get; set; }
        public long? ItemId { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public long? WarehouseId { get; set; }
        public string WarehouseName { get; set; } = null!;
        public int? LeadTimeDays { get; set; }
        public decimal? Quantity { get; set; }
        public decimal SoplineQuantity { get; set; }
        public decimal WolineQuantity { get; set; }
        public decimal KitLineQuantity { get; set; }
        public decimal? QuantityRequired { get; set; }
    }
}
