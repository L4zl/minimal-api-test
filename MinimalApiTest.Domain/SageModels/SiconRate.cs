using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRate
    {
        public long SiconRateId { get; set; }
        public string? ParentType { get; set; }
        public long? ParentId { get; set; }
        public string? RateType { get; set; }
        public int? RateIndex { get; set; }
        public string? Description { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal? DailyRate { get; set; }
        public bool? Available { get; set; }
        public long? NlnominalAccountId { get; set; }
        public string? Nlref { get; set; }
        public string? Nlcc { get; set; }
        public string? Nldept { get; set; }
        public string? Nlname { get; set; }
        public long? ChargeStockItemId { get; set; }
        public long? WipnlnominalAccountId { get; set; }
        public string? Wipnlref { get; set; }
        public string? Wipnlcc { get; set; }
        public string? Wipnldept { get; set; }
        public string? Wipnlname { get; set; }
        public long? BillingNlnominalAccountId { get; set; }
        public string? BillingNlref { get; set; }
        public string? BillingNlcc { get; set; }
        public string? BillingNldept { get; set; }
        public string? BillingNlname { get; set; }
        public bool? IsFixedRate { get; set; }
        public decimal? FixedRate { get; set; }
        public string? FixedRateType { get; set; }
    }
}
