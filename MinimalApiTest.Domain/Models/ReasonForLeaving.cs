namespace MinimalApiTest.Domain.Models
{
    public partial class ReasonForLeaving
    {
        public long ReasonForLeavingId { get; set; }
        public string? Name { get; set; }
        public bool? DefaultReasonForLeaving { get; set; }
        public bool? Paid { get; set; }
        public bool? ShowOnFireList { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
