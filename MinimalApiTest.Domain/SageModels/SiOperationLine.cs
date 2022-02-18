using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiOperationLine
    {
        public long SiOperationLineId { get; set; }
        public long? SiOperationId { get; set; }
        public string? LineType { get; set; }
        public long? SiJcChdId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? Total { get; set; }
        public long? ItemId { get; set; }
        public long? SiconTeamId { get; set; }
        public long? PlantId { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
        public decimal? TotalSellingPrice { get; set; }
        public decimal? UnitSellingPrice { get; set; }
        public long? MachineId { get; set; }
        public decimal? ManningLevel { get; set; }
        public int? RateNumber { get; set; }
        public long? WarehouseId { get; set; }
        public decimal? AllocatedQuantity { get; set; }
        public decimal? IssuedQuantity { get; set; }
        public long? DelayDays { get; set; }
        public decimal? DelayHours { get; set; }
        public decimal? DelayMinutes { get; set; }
        public decimal? DelaySeconds { get; set; }
        public decimal? OverlapQuantity { get; set; }
        public decimal? OverlapPercentage { get; set; }
        public decimal? ManningLevelOverride { get; set; }
        public long? SiconEmployeeId { get; set; }
        public long? SiconMachineId { get; set; }
        public long? SiconMachineGroupId { get; set; }
        public long? SiconTeamGroupId { get; set; }
    }
}
