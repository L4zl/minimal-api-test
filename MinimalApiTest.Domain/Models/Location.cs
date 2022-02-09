namespace MinimalApiTest.Domain.Models
{
    public partial class Location
    {
        public long LocationId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? Deleted { get; set; }
        public bool? IsTouchScreen { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
