namespace MinimalApiTest.Domain.Models
{
    public partial class Pctran
    {
        public long PctransId { get; set; }
        public decimal? Hours { get; set; }
        public long? PcprojectId { get; set; }
        public long? PcprojectItemId { get; set; }
        public long? TimesheetDefaultId { get; set; }
        public string? TransType { get; set; }
        public string? RecordType { get; set; }
        public long? TspersonId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? SentToSage { get; set; }
        public bool? Approved { get; set; }
        public long? TschargeRateId { get; set; }
        public long? TscostRateId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public long? RequestedById { get; set; }
        public long? WaitingForId { get; set; }
        public string? WaitingForType { get; set; }
        public int? CurrentStep { get; set; }
        public string? Narrative { get; set; }
        public string? LineStatusId { get; set; }
        public string? UpdateStatus { get; set; }
        public bool? CustomRoute { get; set; }
        public long? CustomRouteId { get; set; }
        public string? RejectReason { get; set; }
        public long? CurrentStepApprovalCount { get; set; }
        public long? TspayRateId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public long? TimesheetId { get; set; }
        public bool? Submitted { get; set; }
    }
}
