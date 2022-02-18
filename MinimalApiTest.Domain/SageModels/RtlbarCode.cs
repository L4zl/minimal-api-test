using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlbarCode
    {
        public long BarCodeId { get; set; }
        public string? BarCode { get; set; }
        public string? StockItemCode { get; set; }
        public long? PrdHierNodeId { get; set; }
        public string? SupplierReference { get; set; }
        public long BarCodeTypeId { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
