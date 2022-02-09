namespace MinimalApiTest.Domain.Models
{
    public partial class NextNumber
    {
        public long NextNumberId { get; set; }
        public long? CurrentValue { get; set; }
        public string? DocumentType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
