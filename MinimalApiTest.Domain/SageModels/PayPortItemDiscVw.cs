using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PayPortItemDiscVw
    {
        public long? CustomerDiscountGroupId { get; set; }
        public long? PriceBandId { get; set; }
        public long StkItmDiscId { get; set; }
        public string DiscGrpName { get; set; } = null!;
        public string PriceBandName { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public long DiscountTypeId { get; set; }
        public long? CurrencyId { get; set; }
        public long StockItemQtyDiscBreakId { get; set; }
        public decimal QuantityMoreThan { get; set; }
        public decimal DiscountAmountValue { get; set; }
        public decimal DiscountPercentValue { get; set; }
        public long StockItemDiscountId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string? CrncyIsocode { get; set; }
        public bool? ThisIsBaseCurrency { get; set; }
        public string StockUnitName { get; set; } = null!;
        public string ItemUnitName { get; set; } = null!;
    }
}
