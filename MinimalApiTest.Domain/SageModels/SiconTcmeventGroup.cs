using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmeventGroup
    {
        public SiconTcmeventGroup()
        {
            SiconTcmeventDefs = new HashSet<SiconTcmeventDef>();
            SiconTcmeventDescriptions = new HashSet<SiconTcmeventDescription>();
        }

        public long SiconTcmeventGroupId { get; set; }
        public string Name { get; set; } = null!;
        public string Guid { get; set; } = null!;

        public virtual ICollection<SiconTcmeventDef> SiconTcmeventDefs { get; set; }
        public virtual ICollection<SiconTcmeventDescription> SiconTcmeventDescriptions { get; set; }
    }
}
