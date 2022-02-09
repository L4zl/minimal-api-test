namespace MinimalApiTest.Domain.Models
{
    public partial class TimesheetLine
    {
        public long TimesheetLineId { get; set; }
        public long? TimesheetId { get; set; }
        public long? TopLevelProjectId { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectItemId { get; set; }
        public long? ProjectPhaseId { get; set; }
        public long? ProjectStageId { get; set; }
        public long? ProjectSubStageId { get; set; }
        public long? CostRateId { get; set; }
        public long? ChargeRateId { get; set; }
        public long? PayRateId { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
        public string? RejectReason { get; set; }
        public int? CustomRouteId { get; set; }
        public bool? CustomRoute { get; set; }
        public int? CurrentStep { get; set; }
        public int? CurrentStepApprovalCount { get; set; }
        public string? LineStatus { get; set; }
        public int? LineStatusId { get; set; }
        public bool? SentToSage { get; set; }
        public string? Narrative { get; set; }
        public bool? Submitted { get; set; }
        public bool? Amendment { get; set; }
        public long? AmendedTimesheetLineId { get; set; }
        public long? OriginalTimesheetLineId { get; set; }
        public bool? Original { get; set; }
        public long? ConstructVariationId { get; set; }
        public long? ConstructLineTypeId { get; set; }
        public string? Notes { get; set; }
        public long? ConcurrentJobs { get; set; }
        public DateTime? PayrollPostingDate { get; set; }
        public bool? OverBudget { get; set; }
        public long? HolidayRequestLineId { get; set; }
        public long? HrabsenceId { get; set; }
        public long? BankHolidayId { get; set; }
        public long? MandatoryHolidayId { get; set; }
        public string? ErrorMessage { get; set; }
        public string? ModuleString { get; set; }
        public bool ResetRoute { get; set; }
        public long? TransactionId { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public long? CopiedFrom { get; set; }
        public string? CostRateType { get; set; }
        public bool? CreatedByRule { get; set; }
        public string? LineType { get; set; }
        public long SiOperationId { get; set; }
        public long SiJcvariationId { get; set; }
        public decimal? QuantityComplete { get; set; }
        public long? LineNumber { get; set; }
        public bool? RateOverridden { get; set; }
        public bool? Rework { get; set; }
        public decimal? WofinishedItemQuantity { get; set; }
        public string? JobManager { get; set; }
    }
}
