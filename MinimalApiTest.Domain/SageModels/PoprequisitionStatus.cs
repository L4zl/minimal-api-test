using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoprequisitionStatus
    {
        public PoprequisitionStatus()
        {
            PoprequisitionLines = new HashSet<PoprequisitionLine>();
            Poprequisitions = new HashSet<Poprequisition>();
        }

        public long PoprequisitionStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoprequisitionLine> PoprequisitionLines { get; set; }
        public virtual ICollection<Poprequisition> Poprequisitions { get; set; }
    }
}
