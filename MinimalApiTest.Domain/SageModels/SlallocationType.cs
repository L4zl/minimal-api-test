using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlallocationType
    {
        public SlallocationType()
        {
            SlallocationHeaders = new HashSet<SlallocationHeader>();
        }

        public long SlallocationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SlallocationHeader> SlallocationHeaders { get; set; }
    }
}
