using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiStockItemCheckOutList
    {
        public double SiStockItemCheckOutListId { get; set; }
        public double ItemId { get; set; }
        public double ProductGroupId { get; set; }
        public double WarehouseId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public decimal Quantity { get; set; }
        public double BuyingPrice { get; set; }
        public string? Status { get; set; }
        public string StockItemType { get; set; } = null!;
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
        public string? Bin { get; set; }
        public string WarehouseName { get; set; } = null!;
    }
}
