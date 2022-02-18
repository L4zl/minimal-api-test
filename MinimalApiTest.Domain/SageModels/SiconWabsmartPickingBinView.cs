using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabsmartPickingBinView
    {
        public decimal? AvailableToPick { get; set; }
        public long BinOrder { get; set; }
        public long SiconWabzoneId { get; set; }
        public bool IsAdespatchBin { get; set; }
        public long BinItemId { get; set; }
        public long WarehouseItemId { get; set; }
        public string Name { get; set; } = null!;
        public long BinPriority { get; set; }
    }
}
