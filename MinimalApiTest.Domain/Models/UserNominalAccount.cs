namespace MinimalApiTest.Domain.Models
{
    public partial class UserNominalAccount
    {
        public long UserNominalAccountId { get; set; }
        public long? NominalAccountId { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public decimal? MaxLineValue { get; set; }
        public decimal? MaxAuthorisationValue { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
