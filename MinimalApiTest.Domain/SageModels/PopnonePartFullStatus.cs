using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopnonePartFullStatus
    {
        public PopnonePartFullStatus()
        {
            PoprequisitionPoprequisitionAuthorisationStatuses = new HashSet<Poprequisition>();
            PoprequisitionPoprequisitionRejectedStatuses = new HashSet<Poprequisition>();
        }

        public long PopnonePartFullStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Poprequisition> PoprequisitionPoprequisitionAuthorisationStatuses { get; set; }
        public virtual ICollection<Poprequisition> PoprequisitionPoprequisitionRejectedStatuses { get; set; }
    }
}
