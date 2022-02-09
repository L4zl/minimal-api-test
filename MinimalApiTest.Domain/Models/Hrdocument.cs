namespace MinimalApiTest.Domain.Models
{
    public partial class Hrdocument
    {
        public long HrdocumentId { get; set; }
        public long? UserId { get; set; }
        public long? CreatorId { get; set; }
        public bool? IsLocked { get; set; }
        public string? Title { get; set; }
        public string? Version { get; set; }
        public string? Url { get; set; }
        public string? DocumentType { get; set; }
        public bool? NotifyUsers { get; set; }
        public bool? RequireReadConfirmation { get; set; }
        public bool? Deleted { get; set; }
        public bool? DisplayLimited { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DisplayStartDate { get; set; }
        public string? DisplayEndDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? HradminsOnly { get; set; }
    }
}
