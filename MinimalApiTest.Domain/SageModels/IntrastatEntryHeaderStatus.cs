using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class IntrastatEntryHeaderStatus
    {
        public IntrastatEntryHeaderStatus()
        {
            IntrastatEntryHeaders = new HashSet<IntrastatEntryHeader>();
        }

        public long IntrastatEntryHeaderStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<IntrastatEntryHeader> IntrastatEntryHeaders { get; set; }
    }
}
