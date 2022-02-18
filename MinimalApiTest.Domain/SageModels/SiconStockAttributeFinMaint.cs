using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconStockAttributeFinMaint
    {
        public long SiconStockAttributeFinMaintId { get; set; }
        public long? SiconStockAttributeMaintId { get; set; }
        public long? SiBespokeTypeId { get; set; }
        public bool Enabled { get; set; }
        public string? Notes { get; set; }
        public decimal? Days { get; set; }
    }
}
