using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportUndoAllocationComponent
    {
        public long ReportUndoAllocationComponentId { get; set; }
        public long ReportSessionId { get; set; }
        public string ComponentReference { get; set; } = null!;
        public string ComponentDescription { get; set; } = null!;
        public string ParentAssemblyReference { get; set; } = null!;
        public string ParentAssemblyDescription { get; set; } = null!;
        public decimal QuantityUnallocated { get; set; }
        public decimal QuantityRemaining { get; set; }
        public string StockUnitName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ReportSession ReportSession { get; set; } = null!;
    }
}
