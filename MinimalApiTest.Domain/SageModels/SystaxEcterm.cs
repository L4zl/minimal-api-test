using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxEcterm
    {
        public SystaxEcterm()
        {
            SystaxRates = new HashSet<SystaxRate>();
        }

        public long SystaxEctermId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SystaxRate> SystaxRates { get; set; }
    }
}
