namespace MinimalApiTest.Domain.Models
{
    public partial class UserCostingHeader
    {
        public long UserCostingHeaderId { get; set; }
        public long? UserId { get; set; }
        public long? CostingHeaderId { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
