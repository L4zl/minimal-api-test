namespace MinimalApiTest.Domain.Models
{
    public partial class Sage50Department
    {
        public long Sage50DepartmentId { get; set; }
        public long? Number { get; set; }
        public string? Name { get; set; }
        public string? Reference { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
