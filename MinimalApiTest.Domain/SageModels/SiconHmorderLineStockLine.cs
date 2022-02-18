using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLineStockLine
    {
        public long SiconHmorderLineStockLineId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public int? ItemSequenceNo { get; set; }
        public long ItemId { get; set; }
        public decimal? UnitNetValue { get; set; }
        public decimal? UnitNetCost { get; set; }
        public decimal? Quantity { get; set; }
        public long? BinItemId { get; set; }
        public long TaxCodeId { get; set; }
        public decimal? QuantityInvoiced { get; set; }
        public DateTime? ChargeDate { get; set; }
        public bool? AddToLastInvoice { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? ParentAssetLineId { get; set; }
    }
}
