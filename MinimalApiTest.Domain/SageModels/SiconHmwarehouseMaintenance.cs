using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmwarehouseMaintenance
    {
        public long SiconHmwarehouseMaintenanceId { get; set; }
        public long WarehouseId { get; set; }
        public bool? ReferenceEnabled { get; set; }
        public string? Reference { get; set; }
        public bool? CostCentreEnabled { get; set; }
        public string? CostCentre { get; set; }
        public bool? DeptEnabled { get; set; }
        public string? Dept { get; set; }
    }
}
