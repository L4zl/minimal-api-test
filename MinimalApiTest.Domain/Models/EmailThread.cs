namespace MinimalApiTest.Domain.Models
{
    public partial class EmailThread
    {
        public long EmailThreadId { get; set; }
        public string? Description { get; set; }
        public long? IntervalHours { get; set; }
        public long? IntervalMinutes { get; set; }
        public long? IntervalSeconds { get; set; }
        public DateTime? WindowStart { get; set; }
        public DateTime? WindowEnd { get; set; }
        public bool? SendAwaitingApproval { get; set; }
        public bool? SendComplete { get; set; }
        public bool? SendPostedToSage { get; set; }
        public bool? SendRejected { get; set; }
        public bool? SendFullyApproved { get; set; }
        public bool? SendNoApprovers { get; set; }
        public bool? SendGoodsReceived { get; set; }
        public bool? SendEmailRecords { get; set; }
        public bool? Deleted { get; set; }
        public bool? IncludeSentItems { get; set; }
        public DateTime? NextEmailSendTime { get; set; }
        public bool? SendMonday { get; set; }
        public bool? SendTuesday { get; set; }
        public bool? SendWednesday { get; set; }
        public bool? SendThursday { get; set; }
        public bool? SendFriday { get; set; }
        public bool? SendSaturday { get; set; }
        public bool? SendSunday { get; set; }
        public bool? SendSummary { get; set; }
        public bool? SendFullyAllocated { get; set; }
        public bool? SendPartAllocated { get; set; }
        public bool SendOnHold { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
