using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class EdufundType
    {
        public EdufundType()
        {
            NlcostCentres = new HashSet<NlcostCentre>();
        }

        public long EdufundTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<NlcostCentre> NlcostCentres { get; set; }
    }
}
