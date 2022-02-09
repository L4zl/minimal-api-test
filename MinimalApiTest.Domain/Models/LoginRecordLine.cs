namespace MinimalApiTest.Domain.Models
{
    public partial class LoginRecordLine
    {
        public long LoginRecordLineId { get; set; }
        public long? TimesheetId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? WorkPatternPayRateId { get; set; }
        public long? HolidayRequestLineId { get; set; }
        public long? BankHolidayId { get; set; }
        public long? MandatoryHolidayId { get; set; }
        public long? HrabsenceId { get; set; }
        public string? Notes { get; set; }
        public bool? SentToSage { get; set; }
        public long? CopiedFrom { get; set; }
    }
}
