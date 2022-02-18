using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLineAssetsLineItem
    {
        public long ItemId { get; set; }
        public long SiconHmorderLineAssetsLineId { get; set; }
        public long? SiconHmorderLineId { get; set; }
        public long SiconFixedAssetId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityDespatched { get; set; }
        public DateTime? DespatchedDate { get; set; }
        public decimal? QuantityOffHired { get; set; }
        public DateTime? OffHireDate { get; set; }
        public decimal? QuantityReceived { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public decimal? QuantityLost { get; set; }
        public DateTime? LostDate { get; set; }
        public bool? IsLostResolved { get; set; }
        public decimal? UnitRechargeSellingPrice { get; set; }
        public bool? DoNotCharge { get; set; }
        public DateTime? BilledUpTo { get; set; }
        public bool? BillingComplete { get; set; }
        public DateTime? LastHistoryUpdaterDateTime { get; set; }
        public long? LastHistoryAppointmentId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? SiconHmorderLineCreditLineId { get; set; }
    }
}
