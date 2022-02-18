using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemsuppProdMapping
    {
        public long TemsuppProdMappingId { get; set; }
        public long? SupplierId { get; set; }
        public long? StockItemId { get; set; }
        public string? SupplierProductCode { get; set; }
        public string? SupplierProductDesc { get; set; }
        public long? AdditionalChargeId { get; set; }
        public string? AdditionalChargeCode { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem? StockItem { get; set; }
        public virtual PlsupplierAccount? Supplier { get; set; }
    }
}
