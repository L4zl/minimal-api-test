namespace MinimalApiTest.Domain.Models
{
    public partial class Despatch
    {
        public long DespatchId { get; set; }
        public DateTime? DespatchDate { get; set; }
        public string? CustomerAccountNo { get; set; }
        public long? CustomerId { get; set; }
        public string? CustomerDocumentNo { get; set; }
        public DateTime? CustomerDocumentDate { get; set; }
        public string? Narrative { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? Deleted { get; set; }
        public string? UpdateStatus { get; set; }
        public string? Gdnnumber { get; set; }
        public bool? SentToSage { get; set; }
        public bool? FinalDespatch { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
