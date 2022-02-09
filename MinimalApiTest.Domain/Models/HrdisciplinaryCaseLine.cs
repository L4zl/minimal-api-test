namespace MinimalApiTest.Domain.Models
{
    public partial class HrdisciplinaryCaseLine
    {
        public long HrdisciplinaryCaseLineId { get; set; }
        public long? HrdisciplinaryCaseId { get; set; }
        public long? UserId { get; set; }
        public string? LineType { get; set; }
        public string? Description { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
    }
}
