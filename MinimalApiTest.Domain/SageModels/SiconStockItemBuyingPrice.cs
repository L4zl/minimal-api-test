using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockItemBuyingPrice
    {
        public long SiconStockItemBuyingPriceId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public long StockItemId { get; set; }
        public long UnitId { get; set; }
        public string? BuyingPriceType { get; set; }
        public decimal? MinimumQuantity { get; set; }
        public decimal? MaximumQuantity { get; set; }
        public decimal? BuyingPrice { get; set; }
        public string? LastRecordIndicator { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
