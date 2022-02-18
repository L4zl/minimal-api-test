using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomAllocation
    {
        public BomAllocation()
        {
            BomAllocationWarehouses = new HashSet<BomAllocationWarehouse>();
            BomAllocationWopOrderLinks = new HashSet<BomAllocationWopOrderLink>();
            WopOrders = new HashSet<WopOrder>();
        }

        public long BomAllocationId { get; set; }
        public DateTime AllocationDateTime { get; set; }
        public string AllocatedBy { get; set; } = null!;
        public string AllocationReference { get; set; } = null!;
        public string AllocationNumber { get; set; } = null!;
        public bool ReportShortagesForComponents { get; set; }
        public bool ReportShortagesForSubAssemblies { get; set; }
        public short SubassemblyTreatmentType { get; set; }
        public short ShortageFoundAction { get; set; }
        public long BomAllocationStatusId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomAllocationStatus BomAllocationStatus { get; set; } = null!;
        public virtual BomBuildSession BomBuildSession { get; set; } = null!;
        public virtual ICollection<BomAllocationWarehouse> BomAllocationWarehouses { get; set; }
        public virtual ICollection<BomAllocationWopOrderLink> BomAllocationWopOrderLinks { get; set; }
        public virtual ICollection<WopOrder> WopOrders { get; set; }
    }
}
