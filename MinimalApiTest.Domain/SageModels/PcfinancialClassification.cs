using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcfinancialClassification
    {
        public PcfinancialClassification()
        {
            PcprojectEntries = new HashSet<PcprojectEntry>();
        }

        public long PcfinancialClassificationId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
    }
}
