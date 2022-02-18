using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCountSheetItemHistory
    {
        public long SiconCountSheetItemHistoryId { get; set; }
        public long StockTakeId { get; set; }
        public long BinItemId { get; set; }
        public decimal? RecordedQuantityInStock { get; set; }
        public bool? ActualQuantityEntered { get; set; }
        public decimal? ActualQuantityInStock { get; set; }
        public decimal? RecordedTraceUnassigned { get; set; }
        public decimal? ActualTraceUnassigned { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public decimal? QuantityOnPoporder { get; set; }
        public long? StkdiscrepancyStatusId { get; set; }
        public string? DiscrepancyNarrative { get; set; }
    }
}
