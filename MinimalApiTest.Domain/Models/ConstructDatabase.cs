namespace MinimalApiTest.Domain.Models
{
    public partial class ConstructDatabase
    {
        public long ConstructDatabaseId { get; set; }
        public string? Description { get; set; }
        public string? ConnectString { get; set; }
        public bool? Deleted { get; set; }
        public string? DatabaseName { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
