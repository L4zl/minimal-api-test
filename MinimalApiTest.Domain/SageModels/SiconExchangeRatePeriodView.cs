using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconExchangeRatePeriodView
    {
        public long SyscurrencyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? OneUnitEquals { get; set; }
    }
}
