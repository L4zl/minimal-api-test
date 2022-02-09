namespace MinimalApiTest.Domain.Models
{
    public partial class UserFavourite
    {
        public long UserFavouriteId { get; set; }
        public long? UserId { get; set; }
        public string? FavouriteType { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? Value { get; set; }
        public string? EntityId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
