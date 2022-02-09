namespace MinimalApiTest.Domain.Models
{
    public partial class LoginRecord
    {
        public long LoginRecordId { get; set; }
        public long? LocationId { get; set; }
        public long? UserId { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public long? ReasonForLeavingId { get; set; }
        public decimal? Hours { get; set; }
        public string? PayElement { get; set; }
        public string? PayElementRef { get; set; }
        public bool? Amended { get; set; }
        public long? LoginRecordLineId { get; set; }
        public long? DayOfWeek { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
