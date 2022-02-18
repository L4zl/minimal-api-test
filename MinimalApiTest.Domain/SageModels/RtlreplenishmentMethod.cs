using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlreplenishmentMethod
    {
        public long ReplMethodId { get; set; }
        public string Description { get; set; } = null!;
    }
}
