using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopBuildTraceableComponent
    {
        public WopBuildTraceableComponent()
        {
            WopBuildComponentTraceabilities = new HashSet<WopBuildComponentTraceability>();
        }

        public long WopBuildTraceableComponentId { get; set; }
        public long WopBuildComponentId { get; set; }
        public long TraceableItemId { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public decimal Quantity { get; set; }
        public long UnitId { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopBuildComponent WopBuildComponent { get; set; } = null!;
        public virtual ICollection<WopBuildComponentTraceability> WopBuildComponentTraceabilities { get; set; }
    }
}
