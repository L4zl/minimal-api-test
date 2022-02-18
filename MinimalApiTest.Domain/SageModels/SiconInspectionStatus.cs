using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconInspectionStatus
    {
        public long SiconInspectionStatusId { get; set; }
        public string? Description { get; set; }
        public string Name { get; set; } = null!;
        public bool? RaiseNc { get; set; }
        public bool? Deleted { get; set; }
        public bool? Pass { get; set; }
        public bool? ScrapStockItem { get; set; }
        public bool? QuarantineStockItem { get; set; }
    }
}
