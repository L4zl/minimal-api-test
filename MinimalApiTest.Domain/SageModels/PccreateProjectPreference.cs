using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PccreateProjectPreference
    {
        public PccreateProjectPreference()
        {
            Pcsettings = new HashSet<Pcsetting>();
        }

        public long PccreateProjectPreferenceId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Pcsetting> Pcsettings { get; set; }
    }
}
