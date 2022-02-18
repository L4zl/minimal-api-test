using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWorksOrderCostsView
    {
        public DateTime? Day { get; set; }
        public decimal? Week { get; set; }
        public decimal? Year { get; set; }
        public decimal? AvailableHours { get; set; }
        public string? WeekCostItemName { get; set; }
        public string? WeekDept { get; set; }
        public int? WeekBomcostTypeId { get; set; }
        public decimal? SequenceNo { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public string? Wonumber { get; set; }
        public DateTime? WocreatedDate { get; set; }
        public DateTime? WodueDate { get; set; }
        public long? BomlineTypeId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityIssued { get; set; }
        public long? BomunitId { get; set; }
        public string? CostItemName { get; set; }
        public string? CostItemDescription { get; set; }
        public int? BomcostTypeId { get; set; }
        public string? DeptCode { get; set; }
        public string? DeptDescription { get; set; }
        public long? SiWorksOrderDeptId { get; set; }
        public long? SiWorksOrderAvailabilityId { get; set; }
        public string? Wostatus { get; set; }
        public bool? Overtime { get; set; }
        public DateTime? EstimateEndDate { get; set; }
        public decimal? Hours { get; set; }
    }
}
