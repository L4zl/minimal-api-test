using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcanalysisFieldType
    {
        public PcanalysisFieldType()
        {
            PcanalysisFields = new HashSet<PcanalysisField>();
        }

        public long PcanalysisFieldTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PcanalysisField> PcanalysisFields { get; set; }
    }
}
