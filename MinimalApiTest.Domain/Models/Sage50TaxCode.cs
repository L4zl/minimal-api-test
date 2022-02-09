namespace MinimalApiTest.Domain.Models
{
    public partial class Sage50TaxCode
    {
        public long Sage50TaxCodeId { get; set; }
        public string? TaxCode { get; set; }
        public string? Description { get; set; }
        public decimal? TaxRate { get; set; }
        public short? VatInclude { get; set; }
        public short? EuroSales { get; set; }
        public short? EuroPurchase { get; set; }
        public short? RelatedCode { get; set; }
        public decimal? RelatedRate { get; set; }
        public short? IsReversecharge { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
