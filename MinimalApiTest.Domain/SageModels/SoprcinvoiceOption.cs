using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoprcinvoiceOption
    {
        public SoprcinvoiceOption()
        {
            Sopsettings = new HashSet<Sopsetting>();
        }

        public long SoprcinvoiceOptionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Sopsetting> Sopsettings { get; set; }
    }
}
