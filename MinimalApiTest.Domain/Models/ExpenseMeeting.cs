namespace MinimalApiTest.Domain.Models
{
    public partial class ExpenseMeeting
    {
        public long ExpenseMeetingId { get; set; }
        public string? MeetingCode { get; set; }
        public string? MeetingName { get; set; }
        public string? MeetingDescription { get; set; }
        public string? AnalysisCode1 { get; set; }
        public int? MaxPerYear { get; set; }
        public int? MaxPerMonth { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
