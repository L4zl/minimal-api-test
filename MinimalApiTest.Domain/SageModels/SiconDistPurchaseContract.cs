using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPurchaseContract
    {
        public long SiconDistPurchaseContractId { get; set; }
        public long? SupplierId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public bool Deleted { get; set; }
        public string SupplierReference { get; set; } = null!;
        public long? WarehouseId { get; set; }
    }
}
