using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmsubCategoryBalancesView
    {
        public string? SubCategoryDescription { get; set; }
        public long SubCategoryId { get; set; }
        public long CategoryId { get; set; }
        public long? WarehouseId { get; set; }
        public string WarehouseName { get; set; } = null!;
        public decimal? QuantityInStock { get; set; }
        public decimal QuantityQuoted { get; set; }
        public decimal QuantityAllocated { get; set; }
        public decimal QuantityOnHire { get; set; }
        public decimal? QuantityOnInspection { get; set; }
        public decimal QuantityOnOrder { get; set; }
        public decimal? AvailableForHire { get; set; }
    }
}
