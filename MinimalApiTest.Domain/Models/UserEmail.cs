namespace MinimalApiTest.Domain.Models
{
    public partial class UserEmail
    {
        public long UserEmailId { get; set; }
        public long? UserId { get; set; }
        public long? EmailThreadId { get; set; }
        public bool? SendAwaitingApproval { get; set; }
        public bool? SendComplete { get; set; }
        public bool? SendRejected { get; set; }
        public bool? SendFullyApproved { get; set; }
        public bool? SendPostedToSage { get; set; }
        public bool? SendNoApprovers { get; set; }
        public bool? SendGoodsReceived { get; set; }
        public bool? SendEmailRecords { get; set; }
        public bool? SendMonday { get; set; }
        public bool? SendTuesday { get; set; }
        public bool? SendWednesday { get; set; }
        public bool? SendThursday { get; set; }
        public bool? SendFriday { get; set; }
        public bool? SendSaturday { get; set; }
        public bool? SendSunday { get; set; }
        public bool? SendFullyAllocated { get; set; }
        public bool? SendPartAllocated { get; set; }
        public bool? SendOnHold { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
