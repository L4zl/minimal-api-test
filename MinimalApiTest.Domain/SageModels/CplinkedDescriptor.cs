using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CplinkedDescriptor
    {
        public CplinkedDescriptor()
        {
            CpentityCptrans = new HashSet<CpentityCptran>();
        }

        public long CplinkedDescriptorId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CpentityCptran> CpentityCptrans { get; set; }
    }
}
