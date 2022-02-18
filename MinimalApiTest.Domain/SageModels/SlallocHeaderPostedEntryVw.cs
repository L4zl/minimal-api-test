using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlallocHeaderPostedEntryVw
    {
        public long SlallocationHeaderId { get; set; }
        public DateTime AllocationDate { get; set; }
        public int UserNumber { get; set; }
        public string UserName { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public long SlallocationTypeId { get; set; }
        public bool IsComplete { get; set; }
        public long SlpostedCustomerTranId { get; set; }
        public string QueryCode { get; set; } = null!;
        public decimal? TotalDebitAllocation { get; set; }
    }
}
