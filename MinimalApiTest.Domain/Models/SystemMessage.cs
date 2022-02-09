namespace MinimalApiTest.Domain.Models
{
    public partial class SystemMessage
    {
        public long SystemMessageId { get; set; }
        public string? Message { get; set; }
        public DateTime? DisplayUntil { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? PreventLogin { get; set; }
    }
}
