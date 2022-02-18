using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtllocationType
    {
        public long LocationTypeId { get; set; }
        public string Description { get; set; } = null!;
    }
}
