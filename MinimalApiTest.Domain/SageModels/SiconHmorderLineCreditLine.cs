using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLineCreditLine
    {
        public long SiconHmorderLineCreditLineId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public decimal? NetValue { get; set; }
        public decimal? NetCost { get; set; }
        public long? TaxCodeId { get; set; }
        public long? SiconHmorderId { get; set; }
        public long? ItemId { get; set; }
        public DateTime? CreditFromDate { get; set; }
        public DateTime? CreditToDate { get; set; }
        public decimal? CreditDuration { get; set; }
        public bool? IsCredited { get; set; }
        public long? CreditSoporderReturnLineId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
