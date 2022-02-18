using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderCostTransaction
    {
        public long SiWorksOrderCostTransactionId { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public long BomcostItemId { get; set; }
        public decimal? EstimateQuantity { get; set; }
        public decimal? ActualQuantity { get; set; }
        public int? ActualHours { get; set; }
        public byte? ActualMinutes { get; set; }
        public byte? ActualSeconds { get; set; }
        public string? CostName { get; set; }
        public string? CostDescription { get; set; }
        public decimal? CostRate { get; set; }
        public long? BomcostTypeId { get; set; }
        public string? EmployeeName { get; set; }
        public long? SiJcEmpId { get; set; }
        public long? SiJcTrnId { get; set; }
        public bool? AddedAfterCompleted { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? Updateddate { get; set; }
        public string? Updateduser { get; set; }
        public long? SiconTimesheetLineHourId { get; set; }
        public string? MachineReference { get; set; }
        public long? SiconMachineId { get; set; }
        public bool Rework { get; set; }
        public string? ReworkNotes { get; set; }
    }
}
