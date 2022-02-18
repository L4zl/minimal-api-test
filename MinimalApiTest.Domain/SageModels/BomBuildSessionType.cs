using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomBuildSessionType
    {
        public BomBuildSessionType()
        {
            BomBuildSessions = new HashSet<BomBuildSession>();
        }

        public long BomBuildSessionTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomBuildSession> BomBuildSessions { get; set; }
    }
}
