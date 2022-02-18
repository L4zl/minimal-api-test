using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CpentityCptran
    {
        public long CpentityCptranId { get; set; }
        public long CptranId { get; set; }
        public long EntityId { get; set; }
        public long CplinkedDescriptorId { get; set; }

        public virtual CplinkedDescriptor CplinkedDescriptor { get; set; } = null!;
        public virtual Cptran Cptran { get; set; } = null!;
    }
}
