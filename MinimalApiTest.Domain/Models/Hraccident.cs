namespace MinimalApiTest.Domain.Models
{
    public partial class Hraccident
    {
        public long HraccidentId { get; set; }
        public long? AccidentTypeId { get; set; }
        public long? UserId { get; set; }
        public DateTime? TimeOfAccident { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? FollowUpActions { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
