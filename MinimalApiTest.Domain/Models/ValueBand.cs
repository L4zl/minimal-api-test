namespace MinimalApiTest.Domain.Models
{
    public partial class ValueBand
    {
        public long ValueBandId { get; set; }
        public string? Description { get; set; }
        public string? DocumentType { get; set; }
        public decimal? BandStart { get; set; }
        public decimal? BandEnd { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
