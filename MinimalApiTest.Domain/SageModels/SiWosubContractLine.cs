using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWosubContractLine
    {
        public long SiWosubContractLineId { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public long? SourceId { get; set; }
        public string? Type { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? AllocatedQuantity { get; set; }
        public decimal? OriginalCost { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? SiOperationId { get; set; }
        public long? BomOperationId { get; set; }
    }
}
