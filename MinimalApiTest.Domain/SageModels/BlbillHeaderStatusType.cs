using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillHeaderStatusType
    {
        public BlbillHeaderStatusType()
        {
            BlbillHeaderStatuses = new HashSet<BlbillHeaderStatus>();
        }

        public long BlbillHeaderStatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BlbillHeaderStatus> BlbillHeaderStatuses { get; set; }
    }
}
