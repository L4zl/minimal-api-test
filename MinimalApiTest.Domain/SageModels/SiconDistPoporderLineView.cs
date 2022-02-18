using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPoporderLineView
    {
        public long PoporderReturnLineId { get; set; }
        public string ItemCode { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string DocumentNo { get; set; } = null!;
        public long PoporderreturnId { get; set; }
        public string? ItemName { get; set; }
        public string Supplier { get; set; } = null!;
        public DateTime? RequestedDeliveryDate { get; set; }
        public string? ContainerNumber { get; set; }
        public string? ContainerStatus { get; set; }
        public string? ContainerNextStatus { get; set; }
        public string? PoplineStatus { get; set; }
        public int? IsProblem { get; set; }
    }
}
