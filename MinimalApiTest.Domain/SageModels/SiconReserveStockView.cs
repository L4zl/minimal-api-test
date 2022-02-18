using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconReserveStockView
    {
        public long SiconReserveStockId { get; set; }
        public string ReserveNumber { get; set; } = null!;
        public string? CustomerAccountNumber { get; set; }
        public string? CustomerAccountName { get; set; }
        public string? WarehouseName { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string StatusEnumDescription { get; set; } = null!;
    }
}
