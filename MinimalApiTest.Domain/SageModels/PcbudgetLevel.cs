using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcbudgetLevel
    {
        public PcbudgetLevel()
        {
            Pcsettings = new HashSet<Pcsetting>();
        }

        public long PcbudgetLevelId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Pcsetting> Pcsettings { get; set; }
    }
}
