using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomBuildPackageType
    {
        public BomBuildPackageType()
        {
            BomBuildPackages = new HashSet<BomBuildPackage>();
            BomCostSessions = new HashSet<BomCostSession>();
        }

        public long BomBuildPackageTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomBuildPackage> BomBuildPackages { get; set; }
        public virtual ICollection<BomCostSession> BomCostSessions { get; set; }
    }
}
