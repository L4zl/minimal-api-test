using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopcreditCisrctext
    {
        public SopcreditCisrctext()
        {
            Sopsettings = new HashSet<Sopsetting>();
        }

        public long SopcreditCisrctextId { get; set; }
        public string ReverseChargeText { get; set; } = null!;

        public virtual ICollection<Sopsetting> Sopsettings { get; set; }
    }
}
