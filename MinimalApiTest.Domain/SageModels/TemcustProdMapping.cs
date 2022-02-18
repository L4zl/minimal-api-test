using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemcustProdMapping
    {
        public long TemcustProdMappingId { get; set; }
        public long CustomerId { get; set; }
        public long? StockItemId { get; set; }
        public string? CustomersProductCode { get; set; }
        public string? CustomersProductDesc { get; set; }
        public long? AdditionalChargeId { get; set; }
        public string? AdditionalChargeCode { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlcustomerAccount Customer { get; set; } = null!;
        public virtual StockItem? StockItem { get; set; }
    }
}
