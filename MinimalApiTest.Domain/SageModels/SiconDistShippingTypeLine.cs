using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistShippingTypeLine
    {
        public long SiconDistShippingTypeLineId { get; set; }
        public long? SiconDistShippingTypeId { get; set; }
        public string? LineType { get; set; }
        public string? LineValue { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
