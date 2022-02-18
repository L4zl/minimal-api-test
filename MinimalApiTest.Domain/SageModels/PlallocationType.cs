using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlallocationType
    {
        public PlallocationType()
        {
            PlallocationHeaders = new HashSet<PlallocationHeader>();
        }

        public long PlallocationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PlallocationHeader> PlallocationHeaders { get; set; }
    }
}
