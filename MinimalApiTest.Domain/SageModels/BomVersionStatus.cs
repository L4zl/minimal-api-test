using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomVersionStatus
    {
        public BomVersionStatus()
        {
            BomCostSessions = new HashSet<BomCostSession>();
            BomRecords = new HashSet<BomRecord>();
        }

        public long BomVersionStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomCostSession> BomCostSessions { get; set; }
        public virtual ICollection<BomRecord> BomRecords { get; set; }
    }
}
