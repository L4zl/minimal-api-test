using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PriceBookSetting
    {
        public long PriceBookSettingId { get; set; }
        public bool UseLimitedPriceBands { get; set; }
        public bool UseCustomerDiscountGroups { get; set; }
        public bool UseStockItemDiscounts { get; set; }
        public bool UseProductGroupDiscounts { get; set; }
        public bool UseQuantityBasedDiscounts { get; set; }
        public bool UseOrderValueDiscounts { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
