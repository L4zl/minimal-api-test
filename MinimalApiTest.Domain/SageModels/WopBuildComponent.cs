using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopBuildComponent
    {
        public WopBuildComponent()
        {
            WopBuildComponentIssueLinks = new HashSet<WopBuildComponentIssueLink>();
            WopBuildTraceableComponents = new HashSet<WopBuildTraceableComponent>();
        }

        public long WopBuildComponentId { get; set; }
        public long WopBuildProductId { get; set; }
        public long? WopComponentLineId { get; set; }
        public long? ChildWopBuildId { get; set; }
        public string StockCode { get; set; } = null!;
        public decimal Quantity { get; set; }
        public long? UnitId { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopBuild? ChildWopBuild { get; set; }
        public virtual WopBuildProduct WopBuildProduct { get; set; } = null!;
        public virtual WopComponentLine? WopComponentLine { get; set; }
        public virtual ICollection<WopBuildComponentIssueLink> WopBuildComponentIssueLinks { get; set; }
        public virtual ICollection<WopBuildTraceableComponent> WopBuildTraceableComponents { get; set; }
    }
}
