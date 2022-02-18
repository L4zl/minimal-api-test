using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlreplenishmentSource
    {
        public long ReplSourceId { get; set; }
        public string Description { get; set; } = null!;
    }
}
