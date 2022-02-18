using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillHeaderStatus
    {
        public BlbillHeaderStatus()
        {
            Blbills = new HashSet<Blbill>();
        }

        public long BlbillHeaderStatusId { get; set; }
        public long BlbillHeaderStatusTypeId { get; set; }
        public string Assigner { get; set; } = null!;
        public string Comments { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BlbillHeaderStatusType BlbillHeaderStatusType { get; set; } = null!;
        public virtual ICollection<Blbill> Blbills { get; set; }
    }
}
