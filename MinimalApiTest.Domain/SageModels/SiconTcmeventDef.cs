using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmeventDef
    {
        public SiconTcmeventDef()
        {
            SiconTcmeventDescriptions = new HashSet<SiconTcmeventDescription>();
        }

        public long SiconTcmeventDefId { get; set; }
        public long SiconTcmeventGroupId { get; set; }
        public string Name { get; set; } = null!;
        public string Guid { get; set; } = null!;

        public virtual SiconTcmeventGroup SiconTcmeventGroup { get; set; } = null!;
        public virtual ICollection<SiconTcmeventDescription> SiconTcmeventDescriptions { get; set; }
    }
}
