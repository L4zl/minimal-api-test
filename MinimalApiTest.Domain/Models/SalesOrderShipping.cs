namespace MinimalApiTest.Domain.Models
{
    public partial class SalesOrderShipping
    {
        public long SalesOrderShippingId { get; set; }
        public long? SalesOrderId { get; set; }
        public string? ShippingType { get; set; }
        public decimal? TotalPalletWeight { get; set; }
        public string? Carrier { get; set; }
        public string? Service { get; set; }
        public string? VehicleType { get; set; }
        public string? SpecialInstructions { get; set; }
        public DateTime? DateRequired { get; set; }
        public DateTime? CollectDate { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
