namespace MinimalApiTest.Domain.Models
{
    public partial class UserJob
    {
        public long UserJobId { get; set; }
        public long? Sijcjobid { get; set; }
        public long? Sijcchdid { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public decimal? MaxLineValue { get; set; }
        public decimal? MaxAuthorisationValue { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
