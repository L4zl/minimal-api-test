namespace MinimalApiTest.Domain.Models
{
    public partial class JobRole
    {
        public long JobRoleId { get; set; }
        public string? Description { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
