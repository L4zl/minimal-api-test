using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SldateToUseForAgeing
    {
        public SldateToUseForAgeing()
        {
            Slsettings = new HashSet<Slsetting>();
        }

        public long SldateToUseForAgeingId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Slsetting> Slsettings { get; set; }
    }
}
