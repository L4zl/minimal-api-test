using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPrevSalesOrdersView
    {
        public long SoporderReturnId { get; set; }
        public long CustomerId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public long DocumentTypeId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public decimal? LineQuantity { get; set; }
        public decimal? UnitSellingPrice { get; set; }
        public decimal? UnitDiscountPercent { get; set; }
        public string? ItemCode { get; set; }
        public long ItemId { get; set; }
        public string WarehouseName { get; set; } = null!;
    }
}
