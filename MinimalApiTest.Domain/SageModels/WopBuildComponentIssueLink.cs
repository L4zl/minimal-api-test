using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopBuildComponentIssueLink
    {
        public long WopBuildComponentIssueLinkId { get; set; }
        public long WopBuildComponentId { get; set; }
        public long WopIssueId { get; set; }
        public decimal Quantity { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopBuildComponent WopBuildComponent { get; set; } = null!;
        public virtual WopIssue WopIssue { get; set; } = null!;
    }
}
