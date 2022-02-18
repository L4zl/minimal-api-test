using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlallocationHeader
    {
        public PlallocationHeader()
        {
            PlallocationTrans = new HashSet<PlallocationTran>();
        }

        public long PlallocationHeaderId { get; set; }
        public DateTime AllocationDate { get; set; }
        public int UserNumber { get; set; }
        public string UserName { get; set; } = null!;
        public long PlsupplierAccountId { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public long PlallocationTypeId { get; set; }
        public bool? IsComplete { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlallocationType PlallocationType { get; set; } = null!;
        public virtual PlsupplierAccount PlsupplierAccount { get; set; } = null!;
        public virtual ICollection<PlallocationTran> PlallocationTrans { get; set; }
    }
}
