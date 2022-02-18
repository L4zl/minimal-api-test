using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtldeliveryRoute
    {
        public long DelRouteId { get; set; }
        public string Description { get; set; } = null!;
    }
}
