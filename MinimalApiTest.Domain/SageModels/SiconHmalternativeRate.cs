using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmalternativeRate
    {
        public long SiconHmalternativeRateId { get; set; }
        public long SiconHmorderLineAssetsLineId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? FromDate { get; set; }
        public decimal Rate { get; set; }
    }
}
