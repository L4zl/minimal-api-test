using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemactionOnRetrieval
    {
        public TemactionOnRetrieval()
        {
            Temsettings = new HashSet<Temsetting>();
        }

        public long TemactionOnRetrievalId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Temsetting> Temsettings { get; set; }
    }
}
