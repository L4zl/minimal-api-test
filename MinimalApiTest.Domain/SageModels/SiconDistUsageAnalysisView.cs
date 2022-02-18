using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistUsageAnalysisView
    {
        public long ItemId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string WarehouseName { get; set; } = null!;
        public decimal Usage { get; set; }
        public int? MonthNumber { get; set; }
        public string? Month { get; set; }
        public int? Year { get; set; }
        public DateTime? FirstDayOfMonth { get; set; }
    }
}
