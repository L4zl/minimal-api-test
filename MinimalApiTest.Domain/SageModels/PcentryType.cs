using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcentryType
    {
        public PcentryType()
        {
            PcprojectEntries = new HashSet<PcprojectEntry>();
        }

        public long PcentryTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
    }
}
