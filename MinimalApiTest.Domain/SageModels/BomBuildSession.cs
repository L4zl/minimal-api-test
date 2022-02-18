using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomBuildSession
    {
        public BomBuildSession()
        {
            BuildSessionActualNominalPostings = new HashSet<BuildSessionActualNominalPosting>();
            WopBuilds = new HashSet<WopBuild>();
        }

        public long BomBuildSessionId { get; set; }
        public DateTime BuildDateTime { get; set; }
        public string BuiltBy { get; set; } = null!;
        public long BomAllocationId { get; set; }
        public string AllocationReference { get; set; } = null!;
        public string AllocationNumber { get; set; } = null!;
        public string BuildReference { get; set; } = null!;
        public string BuildNumber { get; set; } = null!;
        public long BomBuildSessionStatusId { get; set; }
        public long BomBuildSessionTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public bool SummarisedNominalPostings { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomAllocation BomBuildSessionNavigation { get; set; } = null!;
        public virtual BomBuildSessionStatus BomBuildSessionStatus { get; set; } = null!;
        public virtual BomBuildSessionType BomBuildSessionType { get; set; } = null!;
        public virtual ICollection<BuildSessionActualNominalPosting> BuildSessionActualNominalPostings { get; set; }
        public virtual ICollection<WopBuild> WopBuilds { get; set; }
    }
}
