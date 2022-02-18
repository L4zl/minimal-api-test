using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmserviceInterval
    {
        public long SiSmserviceIntervalId { get; set; }
        public long SiSmserviceTemplateId { get; set; }
        public long SiSmserviceIntervalTypeId { get; set; }
        public string Unit { get; set; } = null!;
        public int? Quantity { get; set; }
        public string? Name { get; set; }
    }
}
