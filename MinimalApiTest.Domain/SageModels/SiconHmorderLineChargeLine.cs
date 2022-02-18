using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLineChargeLine
    {
        public long SiconHmorderLineChargeLineId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public int? ItemSequenceNo { get; set; }
        public long SiconHmadditionalChargeItemId { get; set; }
        public decimal? NetValue { get; set; }
        public decimal? NetCost { get; set; }
        public decimal? PercentOfValueOfOrder { get; set; }
        public long? TaxCodeId { get; set; }
        public bool? AddToLastInvoice { get; set; }
        public DateTime? ChargeDate { get; set; }
        public string? Description { get; set; }
        public decimal? Quantity { get; set; }
        public long? ManualSelectItemId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? ParentAssetLineId { get; set; }
    }
}
