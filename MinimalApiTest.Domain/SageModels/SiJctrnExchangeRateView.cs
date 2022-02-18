using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJctrnExchangeRateView
    {
        public long SiJcTrnId { get; set; }
        public decimal? TranExchangeRate { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
