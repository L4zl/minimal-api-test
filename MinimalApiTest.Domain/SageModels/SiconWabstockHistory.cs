using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabstockHistory
    {
        public long SiconWabstockHistoryId { get; set; }
        public long MovementHistoryId { get; set; }
        public long ForeignId { get; set; }
        public string? PickedBy { get; set; }
        public DateTime? PickedDate { get; set; }
        public int TypeId { get; set; }
        public int ItemId { get; set; }
        public int BinItemId { get; set; }
        public decimal Quantity { get; set; }
        public string? Description { get; set; }
        public string? BarcodeScanned { get; set; }
    }
}
