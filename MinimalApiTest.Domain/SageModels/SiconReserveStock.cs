using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconReserveStock
    {
        public long SiconReserveStockId { get; set; }
        public long? CustomerId { get; set; }
        public long? DefaultWarehouseId { get; set; }
        public string ReserveNumber { get; set; } = null!;
        public int Status { get; set; }
        public string StatusEnumDescription { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; } = null!;
    }
}
