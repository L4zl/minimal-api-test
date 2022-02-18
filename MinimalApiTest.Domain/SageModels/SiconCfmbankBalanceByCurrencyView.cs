using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmbankBalanceByCurrencyView
    {
        public long CbaccountId { get; set; }
        public decimal Total { get; set; }
        public long ForecastDateForeignId { get; set; }
        public long AccountSyscurrencyId { get; set; }
        public int? HasMemos { get; set; }
    }
}
