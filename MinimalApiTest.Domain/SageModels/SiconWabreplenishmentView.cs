using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabreplenishmentView
    {
        public long? ItemId { get; set; }
        public string? StockItemCode { get; set; }
        public string? StockItemName { get; set; }
        public long? StockItemTraceableTypeId { get; set; }
        public long WarehouseId { get; set; }
        public string WarehouseName { get; set; } = null!;
        public long WarehouseItemId { get; set; }
        public long PickBinItemId { get; set; }
        public string PickBinName { get; set; } = null!;
        public decimal? PickBinQuantity { get; set; }
        public decimal Maximum { get; set; }
        public decimal Minimum { get; set; }
        public decimal? ShortageByMinimum { get; set; }
        public decimal Reorder { get; set; }
        public decimal? ShortageByReorder { get; set; }
        public decimal ReplenishLinesQty { get; set; }
        public decimal FutureSupplyQty { get; set; }
        public decimal FutureDemandQty { get; set; }
    }
}
