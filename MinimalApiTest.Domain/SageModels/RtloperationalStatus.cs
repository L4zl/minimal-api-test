using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtloperationalStatus
    {
        public long OperationalStatusId { get; set; }
        public string Description { get; set; } = null!;
    }
}
