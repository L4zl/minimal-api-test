namespace MinimalApiTest.Domain.Models
{
    public partial class JobCostingMemo
    {
        public long JobCostingMemoId { get; set; }
        public long? Memoid { get; set; }
        public long? Sijcjobid { get; set; }
        public long? Memotype { get; set; }
        public string? Memocreatedby { get; set; }
        public DateTime? Memocreateddate { get; set; }
        public string? Memotext { get; set; }
        public bool? SentToSage { get; set; }
        public long? SageDatabaseId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? UpdateStatus { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
