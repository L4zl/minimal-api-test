using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillLineType
    {
        public BlbillLineType()
        {
            BlbillLines = new HashSet<BlbillLine>();
        }

        public long BlbillLineTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BlbillLine> BlbillLines { get; set; }
    }
}
