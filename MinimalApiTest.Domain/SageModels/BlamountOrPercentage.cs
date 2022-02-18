using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlamountOrPercentage
    {
        public BlamountOrPercentage()
        {
            BlbillLines = new HashSet<BlbillLine>();
        }

        public long BlamountOrPercentageId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BlbillLine> BlbillLines { get; set; }
    }
}
