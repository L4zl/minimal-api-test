namespace MinimalApiTest.Domain.Models
{
    public partial class OrderJustification
    {
        public long OrderJustificationId { get; set; }
        public long? OrderId { get; set; }
        public decimal? QuotedPrice { get; set; }
        public long? SyscurrencyId { get; set; }
        public string? SupplierDescription { get; set; }
        public long? DeliveryDays { get; set; }
        public string? Notes { get; set; }
        public bool? Preferred { get; set; }
        public string? PreferredNotes { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
    }
}
