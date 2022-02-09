namespace MinimalApiTest.Domain.Models
{
    public partial class Discount
    {
        public long DiscountId { get; set; }
        public long? SalesOrderLineId { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Value { get; set; }
        public string? Reason { get; set; }
        public long? DiscountType { get; set; }
        public long? Ordinal { get; set; }
        public bool? Deleted { get; set; }
        public long? AddedById { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? SalesOrderLineType { get; set; }
        public decimal? BaseValue { get; set; }
    }
}
