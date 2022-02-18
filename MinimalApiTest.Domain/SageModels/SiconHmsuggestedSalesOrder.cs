using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmsuggestedSalesOrder
    {
        public long SiconHmsuggestedSalesOrderId { get; set; }
        public long? SiconHmbillLineId { get; set; }
        public long? SiconHmbillId { get; set; }
        public long? SiconHmorderLineAssetsLineId { get; set; }
        public long? SellingUnitId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? SiconHmorderLineChargeLineId { get; set; }
        public long? SiconHmorderLineStockLineId { get; set; }
        public long? LineTypeId { get; set; }
        public long? SiconHmorderId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? BillCoverFromDate { get; set; }
        public DateTime? BillCoverToDate { get; set; }
        public int? Duration { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? LineTotal { get; set; }
    }
}
