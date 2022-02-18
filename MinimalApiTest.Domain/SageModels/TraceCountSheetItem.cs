using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TraceCountSheetItem
    {
        public long TraceCountSheetItemId { get; set; }
        public long StocktakeCountShtItemId { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public decimal RecordedQuantityInStock { get; set; }
        public bool ActualQuantityEntered { get; set; }
        public decimal ActualQuantityInStock { get; set; }
        public long? TraceableBinItemId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StocktakeCountSheetItem StocktakeCountShtItem { get; set; } = null!;
        public virtual TraceableBinItem? TraceableBinItem { get; set; }
    }
}
