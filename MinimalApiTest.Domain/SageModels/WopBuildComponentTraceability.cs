using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopBuildComponentTraceability
    {
        public string WopBuildComponentTraceabilityId { get; set; } = null!;
        public long WopBuildTraceableProductId { get; set; }
        public long WopBuildTraceableComponentId { get; set; }
        public decimal ComponentQuantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopBuildTraceableComponent WopBuildTraceableComponent { get; set; } = null!;
        public virtual WopBuildTraceableProduct WopBuildTraceableProduct { get; set; } = null!;
    }
}
