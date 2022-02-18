using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistFreeStock
    {
        public decimal? FreeStock { get; set; }
        public string? Code { get; set; }
        public string? BinName { get; set; }
        public string? WarehouseName { get; set; }
        public string? CompanyName { get; set; }
        public decimal? WarehouseFreeStock { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
