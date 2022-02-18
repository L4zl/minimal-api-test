using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomBuildSessionStatus
    {
        public BomBuildSessionStatus()
        {
            BomBuildSessions = new HashSet<BomBuildSession>();
        }

        public long BomBuildSessionStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomBuildSession> BomBuildSessions { get; set; }
    }
}
