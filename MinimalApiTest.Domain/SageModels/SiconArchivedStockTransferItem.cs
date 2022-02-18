using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconArchivedStockTransferItem
    {
        public long SiconArchivedTransferItemId { get; set; }
        public long SiconArchivedStockTransferId { get; set; }
        public long? ItemId { get; set; }
        public long? BinItemId { get; set; }
        public long? ToBinItemId { get; set; }
        public decimal? QuantityRequested { get; set; }
        public decimal? QuantityPicked { get; set; }
        public decimal? QuantityDespatched { get; set; }
        public decimal? QuantityReceived { get; set; }
        public long? ForeignReference { get; set; }
        public int? Type { get; set; }
        public string? Streference { get; set; }
        public string? StsecondReference { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? CurrentWarehouseItemId { get; set; }
    }
}
