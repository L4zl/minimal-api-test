namespace MinimalApiTest.Domain.Models
{
    public partial class Department
    {
        public long DepartmentId { get; set; }
        public long? ForeignId { get; set; }
        public string? DepartmentName { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
