namespace MinimalApiTest.Domain.Models
{
    public partial class Hrcontact
    {
        public long HrcontactId { get; set; }
        public long? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? Relationship { get; set; }
        public string? Telephone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
