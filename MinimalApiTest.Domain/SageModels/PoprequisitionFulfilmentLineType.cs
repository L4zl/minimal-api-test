using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoprequisitionFulfilmentLineType
    {
        public PoprequisitionFulfilmentLineType()
        {
            PoprequisitionFulfilmentLines = new HashSet<PoprequisitionFulfilmentLine>();
        }

        public long PoprequisitionFulfilmentLineTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoprequisitionFulfilmentLine> PoprequisitionFulfilmentLines { get; set; }
    }
}
