using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlallocHeaderPostedEntryVw
    {
        public long PlallocationHeaderId { get; set; }
        public DateTime AllocationDate { get; set; }
        public int UserNumber { get; set; }
        public string UserName { get; set; } = null!;
        public long PlsupplierAccountId { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public long PlallocationTypeId { get; set; }
        public bool IsComplete { get; set; }
        public long PlpostedSupplierTranId { get; set; }
        public string QueryCode { get; set; } = null!;
        public decimal? TotalDebitAllocation { get; set; }
    }
}
