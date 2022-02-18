using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderGenerationType
    {
        public PoporderGenerationType()
        {
            Popsettings = new HashSet<Popsetting>();
        }

        public long PoporderGenerationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Popsetting> Popsettings { get; set; }
    }
}
