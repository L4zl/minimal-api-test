namespace MinimalApiTest.Domain.Models
{
    public partial class UserSubsistenceIncidental
    {
        public long UserSubsistenceIncidentalsId { get; set; }
        public long? SubsistenceIncidentalsId { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? NominalAccountId { get; set; }
        public long? TaxRateId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
