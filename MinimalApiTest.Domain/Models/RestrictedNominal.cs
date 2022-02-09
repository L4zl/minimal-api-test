namespace MinimalApiTest.Domain.Models
{
    public partial class RestrictedNominal
    {
        public long RestrictedNominalId { get; set; }
        public long? NominalId { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? Deleted { get; set; }
    }
}
