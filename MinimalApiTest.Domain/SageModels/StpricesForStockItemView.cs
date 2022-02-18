using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StpricesForStockItemView
    {
        public string? MmsstpPriceBandName { get; set; }
        public string? MmsstpDescription { get; set; }
        public long? MmsstpPriceBandId { get; set; }
        public decimal MmsstpPrice { get; set; }
        public long MmsstpItemId { get; set; }
        public string? MmsstpCurrencyName { get; set; }
        public string MmsstpCustomerAccountNumber { get; set; } = null!;
        public long? MmsstpCustomersPriceBandId { get; set; }
    }
}
