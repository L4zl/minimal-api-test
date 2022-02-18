using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderBombyProduct
    {
        public long SiWorksOrderBombyProductId { get; set; }
        public long? BomrecordId { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public bool? Deleted { get; set; }
    }
}
