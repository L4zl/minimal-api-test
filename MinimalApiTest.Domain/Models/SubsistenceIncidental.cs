namespace MinimalApiTest.Domain.Models
{
    public partial class SubsistenceIncidental
    {
        public long SubsistenceIncidentalsId { get; set; }
        public decimal? Rate { get; set; }
        public string? Name { get; set; }
        public string? CurrencyIsocode { get; set; }
        public long? ClaimsPerMonth { get; set; }
        public long? ClaimsPerYear { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? MinimumRequiredAttachments { get; set; }
        public long? MinimumRequiredAttachmentsNoReceipt { get; set; }
    }
}
