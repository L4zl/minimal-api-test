namespace MinimalApiTest.Domain.Models
{
    public partial class JustificationValueBand
    {
        public long JustificationValueBandId { get; set; }
        public string? Description { get; set; }
        public string? DocumentType { get; set; }
        public long? SageDatabaseId { get; set; }
        public decimal? BandStart { get; set; }
        public decimal? BandEnd { get; set; }
        public long? ItemsRequired { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
