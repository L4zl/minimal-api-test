using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCurrentExchangeRateView
    {
        public long SyscurrencyId { get; set; }
        public string? Code { get; set; }
        public string Symbol { get; set; } = null!;
        public decimal? OneUnitBaseEquals { get; set; }
    }
}
