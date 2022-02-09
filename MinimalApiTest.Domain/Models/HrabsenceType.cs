namespace MinimalApiTest.Domain.Models
{
    public partial class HrabsenceType
    {
        public long HrabsenceTypeId { get; set; }
        public string? Name { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
