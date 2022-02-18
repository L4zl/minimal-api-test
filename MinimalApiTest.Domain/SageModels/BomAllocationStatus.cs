using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomAllocationStatus
    {
        public BomAllocationStatus()
        {
            BomAllocations = new HashSet<BomAllocation>();
        }

        public long BomAllocationStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomAllocation> BomAllocations { get; set; }
    }
}
