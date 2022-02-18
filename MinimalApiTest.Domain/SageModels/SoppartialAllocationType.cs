using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoppartialAllocationType
    {
        public SoppartialAllocationType()
        {
            Sopsettings = new HashSet<Sopsetting>();
        }

        public long SoppartialAllocationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Sopsetting> Sopsettings { get; set; }
    }
}
