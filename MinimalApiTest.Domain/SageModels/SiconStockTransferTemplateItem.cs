using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockTransferTemplateItem
    {
        public long SiconStockTransferTempItemId { get; set; }
        public long? ItemId { get; set; }
        public long? BinItemId { get; set; }
        public long? ToBinItemId { get; set; }
        public decimal? QuantityRequested { get; set; }
        public int? Type { get; set; }
        public string? Streference { get; set; }
        public string? StsecondReference { get; set; }
        public long? CurrentWarehouseItemId { get; set; }
        public string SiconStockTranferTemplateId { get; set; } = null!;
    }
}
