using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StitemDetailsView
    {
        public string? MmsstdStockItemCode { get; set; }
        public string MmsstdStockItemName { get; set; } = null!;
        public string MmsstdStockItemGroupDescription { get; set; } = null!;
        public string MmsstdStockItemDescription { get; set; } = null!;
        public string MmsstdStockItemTaxRateName { get; set; } = null!;
        public short MmsstdStockItemTaxrate { get; set; }
        public string? MmsstdStockUnitName { get; set; }
        public double? MmsstdStockItemAverageBuyingPrice { get; set; }
        public long MmsstdStockItemId { get; set; }
        public double? MmsstdStockItemStandardCost { get; set; }
        public string? MmsstdStockItemCostingMethodName { get; set; }
        public long? MmsstdStockItemStatusId { get; set; }
    }
}
