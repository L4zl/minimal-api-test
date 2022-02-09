namespace MinimalApiTest.Domain.Models
{
    public partial class SalesOrderShippingLine
    {
        public long SalesOrderShippingLineId { get; set; }
        public long? SalesOrderShippingId { get; set; }
        public string? PalletDimensions { get; set; }
        public string? ParcelDimensions { get; set; }
        public decimal? Qty { get; set; }
        public string? ParcelWeight { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
