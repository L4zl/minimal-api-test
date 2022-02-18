using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEcrapproval
    {
        public long SiconEcrapprovalId { get; set; }
        public string SiconEcrcaseId { get; set; } = null!;
        public long? SiconTeamUserId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string TeamName { get; set; } = null!;
    }
}
