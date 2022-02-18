using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportUndoAllocationFinishedItem
    {
        public long ReportUndoAllocationFinishedItemId { get; set; }
        public long ReportSessionId { get; set; }
        public string AllocationReference { get; set; } = null!;
        public string AllocationNumber { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal QuantityUnallocated { get; set; }
        public decimal QuantityRemaining { get; set; }
        public string StockUnitName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}
