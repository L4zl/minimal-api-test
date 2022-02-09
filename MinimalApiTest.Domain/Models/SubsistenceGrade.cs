namespace MinimalApiTest.Domain.Models
{
    public partial class SubsistenceGrade
    {
        public long SubsistenceGradeId { get; set; }
        public string? Description { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
