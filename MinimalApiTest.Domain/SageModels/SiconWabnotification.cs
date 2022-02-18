using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabnotification
    {
        public long SiconWabnotificationId { get; set; }
        public string? Barcode { get; set; }
        public string? Reason { get; set; }
        public string? UserName { get; set; }
        public DateTime DateTime { get; set; }
        public string? Type { get; set; }
        public bool? Problem { get; set; }
        public long? StockItemId { get; set; }
        public string? StockItemCode { get; set; }
        public string? StockItemName { get; set; }
        public long? BinItemId { get; set; }
        public string? BinName { get; set; }
        public long? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }
    }
}
