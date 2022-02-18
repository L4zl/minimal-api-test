using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StocktakeCountSheetItem
    {
        public StocktakeCountSheetItem()
        {
            TraceCountSheetItems = new HashSet<TraceCountSheetItem>();
        }

        public long StocktakeCountShtItemId { get; set; }
        public long BinItemId { get; set; }
        public long StocktakeId { get; set; }
        public decimal RecordedQuantityInStock { get; set; }
        public bool ActualQuantityEntered { get; set; }
        public decimal ActualQuantityInStock { get; set; }
        public decimal RecordedTraceUnassigned { get; set; }
        public decimal ActualTraceUnassigned { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal QuantityOnPoporder { get; set; }
        public long StkdiscrepancyStatusId { get; set; }
        public string DiscrepancyNarrative { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BinItem BinItem { get; set; } = null!;
        public virtual StkdiscrepancyStatus StkdiscrepancyStatus { get; set; } = null!;
        public virtual Stocktake Stocktake { get; set; } = null!;
        public virtual ICollection<TraceCountSheetItem> TraceCountSheetItems { get; set; }
    }
}
