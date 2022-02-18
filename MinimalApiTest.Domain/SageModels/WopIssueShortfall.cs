using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopIssueShortfall
    {
        public long WopIssueShortfallId { get; set; }
        public long WopIssueId { get; set; }
        public long MovementBalanceId { get; set; }
        public DateTime DateTime { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual WopIssue WopIssue { get; set; } = null!;
    }
}
