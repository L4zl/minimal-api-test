namespace MinimalApiTest.Domain.Models
{
    public partial class SalesQuoteLayout
    {
        public long SalesQuoteLayoutId { get; set; }
        public string? Name { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? Type { get; set; }
    }
}
