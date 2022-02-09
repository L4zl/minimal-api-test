namespace MinimalApiTest.Domain.Models
{
    public partial class UserCostingItemType
    {
        public long UserCostingItemTypeId { get; set; }
        public long? UserId { get; set; }
        public long? CostingItemTypeId { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
