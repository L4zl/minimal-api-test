namespace MinimalApiTest.Domain.Models
{
    public partial class NominalAccountDescription
    {
        public long NominalAccountDescriptionId { get; set; }
        public long? NominalAccountId { get; set; }
        public string? Description { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
