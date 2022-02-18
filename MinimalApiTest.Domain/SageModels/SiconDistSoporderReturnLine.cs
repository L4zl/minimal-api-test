using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSoporderReturnLine
    {
        public long? SiconDistSoporderReturnLineId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public decimal? PreallocatedQuantity { get; set; }
        public string? PoporderNo { get; set; }
        public DateTime? PopdeliveryDate { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? Migrated { get; set; }
    }
}
