using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCustomerSpecialPricesVw
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public string StockItemCode { get; set; } = null!;
        public string StockItemName { get; set; } = null!;
        public decimal QuantityMoreThan { get; set; }
        public decimal DiscountPercentValue { get; set; }
        public decimal DiscountAmountValue { get; set; }
        public string DiscountTypeName { get; set; } = null!;
        public long StockItemQtyDiscBreakId { get; set; }
        public long StockItemDiscountId { get; set; }
        public string CustomerDiscountGroupName { get; set; } = null!;
        public long ProductGroupId { get; set; }
        public string StockItemDiscountName { get; set; } = null!;
        public string? CurrencySymbol { get; set; }
        public string? CurrencyIsocode { get; set; }
    }
}
