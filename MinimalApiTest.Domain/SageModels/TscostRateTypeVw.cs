using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TscostRateTypeVw
    {
        public long TscostRateId { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
    }
}
