using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcbillStatus
    {
        public PcbillStatus()
        {
            PcprojectEntries = new HashSet<PcprojectEntry>();
        }

        public long PcbillStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
    }
}
