using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistShippingLine
    {
        public long SiconDistShippingLineId { get; set; }
        public long? SiconDistShippingId { get; set; }
        public long? LineNumber { get; set; }
        public string? Dimensions { get; set; }
        public long? Quantity { get; set; }
        public string? Weight { get; set; }
        public bool Deleted { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
