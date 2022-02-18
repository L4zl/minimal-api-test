using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BldiscountOrSurcharge
    {
        public BldiscountOrSurcharge()
        {
            BlbillLines = new HashSet<BlbillLine>();
        }

        public long BldiscountOrSurchargeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BlbillLine> BlbillLines { get; set; }
    }
}
