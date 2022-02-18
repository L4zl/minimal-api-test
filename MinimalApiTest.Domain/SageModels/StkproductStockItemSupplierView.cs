using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkproductStockItemSupplierView
    {
        public long? StockItemSupplierId { get; set; }
        public long? SupplierLandedCostsTypeId { get; set; }
        public decimal? SupplierLandedCostsValue { get; set; }
        public long StockLandedCostsTypeId { get; set; }
        public decimal StockLandedCostsValue { get; set; }
        public long ProductGroupId { get; set; }
    }
}
