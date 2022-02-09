namespace MinimalApiTest.Domain.Models
{
    public partial class UserDepartment
    {
        public long UserDepartmentId { get; set; }
        public long? UserId { get; set; }
        public long? DepartmentId { get; set; }
        public bool? DefaultDepartment { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
