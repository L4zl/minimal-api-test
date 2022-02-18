using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopinvoiceCisrctext
    {
        public SopinvoiceCisrctext()
        {
            Sopsettings = new HashSet<Sopsetting>();
        }

        public long SopinvoiceCisrctextId { get; set; }
        public string ReverseChargeText { get; set; } = null!;

        public virtual ICollection<Sopsetting> Sopsettings { get; set; }
    }
}
