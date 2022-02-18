using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPrevPopordersView
    {
        public long PoporderReturnId { get; set; }
        public long? SupplierId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public long DocumentTypeId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public decimal? LineQuantity { get; set; }
        public decimal? UnitBuyingPrice { get; set; }
        public decimal? UnitDiscountPercent { get; set; }
        public string? ItemCode { get; set; }
        public long ItemId { get; set; }
        public string WarehouseName { get; set; } = null!;
    }
}
