using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Poprequisition
    {
        public Poprequisition()
        {
            PoprequisitionLines = new HashSet<PoprequisitionLine>();
        }

        public long PoprequisitionId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public long PoprequisitionStatusId { get; set; }
        public long PoprequisitionAuthorisationStatusId { get; set; }
        public long PoprequisitionRejectedStatusId { get; set; }
        public long PoprequisitionCreatedByUserId { get; set; }
        public string PoprequisitionCreatedByUserName { get; set; } = null!;
        public string RequesterComment { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopnonePartFullStatus PoprequisitionAuthorisationStatus { get; set; } = null!;
        public virtual PopnonePartFullStatus PoprequisitionRejectedStatus { get; set; } = null!;
        public virtual PoprequisitionStatus PoprequisitionStatus { get; set; } = null!;
        public virtual ICollection<PoprequisitionLine> PoprequisitionLines { get; set; }
    }
}
