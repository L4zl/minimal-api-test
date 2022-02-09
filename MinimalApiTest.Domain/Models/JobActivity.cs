namespace MinimalApiTest.Domain.Models
{
    public partial class JobActivity
    {
        public long JobActivityId { get; set; }
        public long? UserId { get; set; }
        public long? ForeignKey { get; set; }
        public long? ForeignKey2 { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Module { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? TransactionId { get; set; }
        public DateTime? DueDate { get; set; }
        public long SiOperationId { get; set; }
        public decimal? QuantityComplete { get; set; }
        public long TimesheetLineId { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public bool? Rework { get; set; }
        public decimal? WofinishedItemQuantity { get; set; }
    }
}
