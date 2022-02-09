namespace MinimalApiTest.Domain.Models
{
    public partial class UserRole
    {
        public long UserRoleId { get; set; }
        public long? UserId { get; set; }
        public long? UserTypeId { get; set; }
        public bool? IsDefault { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
