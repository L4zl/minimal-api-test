using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class IntrastatDestinationType
    {
        public IntrastatDestinationType()
        {
            IntrastatEntryHeaders = new HashSet<IntrastatEntryHeader>();
        }

        public long IntrastatDestinationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<IntrastatEntryHeader> IntrastatEntryHeaders { get; set; }
    }
}
