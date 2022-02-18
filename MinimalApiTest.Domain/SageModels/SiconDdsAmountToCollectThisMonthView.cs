using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsAmountToCollectThisMonthView
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public decimal? AmountToCollect { get; set; }
    }
}
