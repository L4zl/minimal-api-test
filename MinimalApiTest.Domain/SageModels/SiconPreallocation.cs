using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPreallocation
    {
        public long SiconPreallocationId { get; set; }
        public long? StockItemId { get; set; }
        public long? OutForeignId { get; set; }
        public int? OutType { get; set; }
        public string? OutTypeDescription { get; set; }
        public string? OutDocumentNo { get; set; }
        public decimal? PreallocatedQuantity { get; set; }
        public decimal? AllocatedQuantity { get; set; }
        public long? InForeignId { get; set; }
        public int? InType { get; set; }
        public string? InTypeDescription { get; set; }
        public string? InDocumentNo { get; set; }
        public bool Completed { get; set; }
        public bool Deleted { get; set; }
        public string? StockCode { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? WarehouseId { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDateTime { get; set; }
    }
}
