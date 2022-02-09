namespace MinimalApiTest.Domain.Models
{
    public partial class UserProjectItemType
    {
        public long UserProjectItemTypeId { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ProjectItemTypeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
