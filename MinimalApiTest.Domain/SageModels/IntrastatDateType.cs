using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class IntrastatDateType
    {
        public IntrastatDateType()
        {
            Popsettings = new HashSet<Popsetting>();
            Sopsettings = new HashSet<Sopsetting>();
        }

        public long IntrastatDateTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Popsetting> Popsettings { get; set; }
        public virtual ICollection<Sopsetting> Sopsettings { get; set; }
    }
}
