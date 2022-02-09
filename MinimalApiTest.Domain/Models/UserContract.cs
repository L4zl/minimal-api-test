namespace MinimalApiTest.Domain.Models
{
    public partial class UserContract
    {
        public long UserContractId { get; set; }
        public long? ContractId { get; set; }
        public long? ContractItemId { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ConstructDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
