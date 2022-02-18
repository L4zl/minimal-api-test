using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SltranToShowOnStatement
    {
        public SltranToShowOnStatement()
        {
            Slsettings = new HashSet<Slsetting>();
        }

        public long SltranToShowOnStatementsId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Slsetting> Slsettings { get; set; }
    }
}
