using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconExchangeRateDateView
    {
        public long SysexchangeRateHistoryId { get; set; }
        public long? SyscurrencyId { get; set; }
        public string? CurrencyName { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? DateAndTimeActionPerformed { get; set; }
    }
}
