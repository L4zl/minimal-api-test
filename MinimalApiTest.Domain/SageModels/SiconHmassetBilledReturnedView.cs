using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetBilledReturnedView
    {
        public long ItemId { get; set; }
        public long SiconHmorderLineAssetsLineId { get; set; }
        public long SiconHmbillLineItemId { get; set; }
        public long SiconHmbillLineId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public long SiconHmorderId { get; set; }
        public string? HireOrderNumber { get; set; }
        public int SequenceNo { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public long SiconFixedAssetId { get; set; }
        public string? FixedAssetCode { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? BilledToDate { get; set; }
        public DateTime? OffHireDate { get; set; }
        public int? ReceivedEarlyDays { get; set; }
        public int? OffHiredEarlyDays { get; set; }
        public decimal? DailyUnitPrice { get; set; }
        public long? SiconHmorderLineCreditLineId { get; set; }
    }
}
