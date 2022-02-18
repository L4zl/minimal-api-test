using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHireMovementsView
    {
        public long SiconHmorderLineAssetsLineId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long CategoryId { get; set; }
        public long SubCategoryId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? QuantityDespatched { get; set; }
        public decimal? QuantityReceived { get; set; }
        public string? SubCategoryDescription { get; set; }
        public DateTime? MovementDate { get; set; }
        public string TransType { get; set; } = null!;
        public long? WarehouseId { get; set; }
        public string? AccountName { get; set; }
    }
}
