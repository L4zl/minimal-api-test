namespace MinimalApiTest.Domain.Models
{
    public partial class LeaveType
    {
        public long LeaveTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public bool? System { get; set; }
        public bool? Toil { get; set; }
        public bool? ShowOnLeaveCalendar { get; set; }
        public bool? UpdateRecords { get; set; }
        public bool? Display { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
