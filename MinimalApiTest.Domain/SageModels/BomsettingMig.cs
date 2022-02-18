using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomsettingMig
    {
        public long BomsettingId { get; set; }
        public bool UseVersions { get; set; }
        public bool KeepChangeHistory { get; set; }
        public bool AllocateOverhead { get; set; }
        public decimal StockOhallocationRatio { get; set; }
        public decimal CostOhallocationRatio { get; set; }
        public bool DirectMakeupPosting { get; set; }
        public string? NominalDirectAccountRef { get; set; }
        public string? NominalDirectCostCentre { get; set; }
        public string? NominalDirectCostDept { get; set; }
        public string? NominalOhaccountRef { get; set; }
        public string? NominalOhcostCentre { get; set; }
        public string? NominalOhcostDepartment { get; set; }
        public long BommakeupStockOptionId { get; set; }
        public long BommakeupSubAssOptionId { get; set; }
        public bool NonStdCostsDirty { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
