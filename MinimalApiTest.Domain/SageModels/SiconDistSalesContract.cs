using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSalesContract
    {
        public long SiconDistSalesContractId { get; set; }
        public long? CustomerId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public bool Deleted { get; set; }
        public string CustomerReference { get; set; } = null!;
        public long? WarehouseId { get; set; }
    }
}
