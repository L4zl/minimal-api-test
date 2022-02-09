namespace MinimalApiTest.Domain.Models
{
    public partial class HrcourseType
    {
        public long HrcourseTypeId { get; set; }
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
