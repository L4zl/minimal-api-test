using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPocanPreallocateView
    {
        public string ItemCode { get; set; } = null!;
        public string DocumentNo { get; set; } = null!;
        public long PoporderReturnLineId { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public decimal? Quantity { get; set; }
        public long WarehouseId { get; set; }
        public string SupplierAccountName { get; set; } = null!;
        public string SupplierDocumentNo { get; set; } = null!;
    }
}
