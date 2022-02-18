using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomComponentLineType
    {
        public BomComponentLineType()
        {
            BomComponentLines = new HashSet<BomComponentLine>();
        }

        public long BomComponentLineTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomComponentLine> BomComponentLines { get; set; }
    }
}
