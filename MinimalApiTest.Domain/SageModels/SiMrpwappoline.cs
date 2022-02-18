using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiMrpwappoline
    {
        public long SiMrpwappolineId { get; set; }
        public long? SiMrpwappoid { get; set; }
        public DateTime? RequestedDate { get; set; }
        public long? ItemId { get; set; }
        public string? ItemCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public long? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }
        public string? Description { get; set; }
        public long? WaporderLineId { get; set; }
        public long? WaporderId { get; set; }
        public string? WaplineStatus { get; set; }
        public string? WaplineWaitingFor { get; set; }
        public bool? Deleted { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? StockItemUnitId { get; set; }
    }
}
