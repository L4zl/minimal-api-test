using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemoutputOption
    {
        public TemoutputOption()
        {
            Temsettings = new HashSet<Temsetting>();
        }

        public long TemoutputOptionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Temsetting> Temsettings { get; set; }
    }
}
