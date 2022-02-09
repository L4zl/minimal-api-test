namespace MinimalApiTest.Domain.Models
{
    public partial class Wapqueue
    {
        public long WapqueueId { get; set; }
        public string? DocumentType { get; set; }
        public long? ForeignId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ForeignChildId { get; set; }
        public string? ActionType { get; set; }
        public long CurrentStep { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? ApproverId { get; set; }
    }
}
