using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomOperationLineType
    {
        public BomOperationLineType()
        {
            BomOperationLines = new HashSet<BomOperationLine>();
        }

        public long BomOperationLineTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<BomOperationLine> BomOperationLines { get; set; }
    }
}
