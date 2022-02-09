namespace MinimalApiTest.Domain.Models
{
    public partial class TimesheetDefault
    {
        public long TimesheetDefaultId { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? System { get; set; }
    }
}
