namespace MinimalApiTest.Domain.Models
{
    public partial class SalesOrderPriceBand
    {
        public long SalesOrderPriceBandId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? CurrentPriceBandId { get; set; }
        public long? ReplacementPriceBandId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
