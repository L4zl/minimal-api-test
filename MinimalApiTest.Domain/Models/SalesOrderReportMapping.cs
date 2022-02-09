namespace MinimalApiTest.Domain.Models
{
    public partial class SalesOrderReportMapping
    {
        public long SalesOrderReportMappingId { get; set; }
        public int? SalesOrderReportId { get; set; }
        public string? Qty { get; set; }
        public string? UnitPrice { get; set; }
        public string? Discount { get; set; }
        public string? TotalPrice { get; set; }
        public string? DeliveryDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public int? LinesStartIndex { get; set; }
        public int? LinesDifference { get; set; }
        public int? OrderTotalDifference { get; set; }
        public string? OrderTotalPrice { get; set; }
    }
}
