using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PltotalOverdueBalancesView
    {
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public string SupplierAccountShortName { get; set; } = null!;
        public long PlsupplierAccountId { get; set; }
        public decimal? GoodsValueInAccountCurrencyTotal { get; set; }
        public decimal? AllocatedValueTotal { get; set; }
        public decimal? Balance { get; set; }
    }
}
