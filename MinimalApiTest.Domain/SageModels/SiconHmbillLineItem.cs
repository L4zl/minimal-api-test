using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmbillLineItem
    {
        public long SiconHmbillLineItemId { get; set; }
        public long SiconHmbillLineId { get; set; }
        public long? ItemId { get; set; }
        public DateTime? BilledFromDate { get; set; }
        public DateTime? BilledToDate { get; set; }
        public int? BilledNumberOfDays { get; set; }
        public decimal? BilledTotalHireCharge { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public DateTime? BilledOffHireDate { get; set; }
        public int? BilledSuspensionDays { get; set; }
        public int? BilledBhdays { get; set; }
        public int? BilledTotalDaysLessExclusions { get; set; }
    }
}
