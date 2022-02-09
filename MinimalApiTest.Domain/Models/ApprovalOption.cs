namespace MinimalApiTest.Domain.Models
{
    public partial class ApprovalOption
    {
        public long ApprovalOptionId { get; set; }
        public string? DocumentType { get; set; }
        public bool? ByValue { get; set; }
        public bool? ByNominalAccount { get; set; }
        public bool? ByUser { get; set; }
        public bool? ByProject { get; set; }
        public bool? ByProjectItem { get; set; }
        public bool? ApproveAsSingleDoc { get; set; }
        public bool? RequiresApproval { get; set; }
        public string? ApprovalValueSource { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? BySupplier { get; set; }
        public bool? ByJobManager { get; set; }
    }
}
