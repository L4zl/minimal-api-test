using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlallocationHeader
    {
        public SlallocationHeader()
        {
            SlallocationTrans = new HashSet<SlallocationTran>();
        }

        public long SlallocationHeaderId { get; set; }
        public DateTime AllocationDate { get; set; }
        public int UserNumber { get; set; }
        public string UserName { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public long SlallocationTypeId { get; set; }
        public bool? IsComplete { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlallocationType SlallocationType { get; set; } = null!;
        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
        public virtual ICollection<SlallocationTran> SlallocationTrans { get; set; }
    }
}
