using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPurchaseContractView
    {
        public long SiconDistPurchaseContractId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string SupplierReference { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
    }
}
