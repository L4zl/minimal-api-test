namespace MinimalApiTest.Domain.Models
{
    public partial class HrdisciplinaryCase
    {
        public long HrdisciplinaryCaseId { get; set; }
        public long? UserId { get; set; }
        public long? InvestigatorId { get; set; }
        public string? CaseType { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
