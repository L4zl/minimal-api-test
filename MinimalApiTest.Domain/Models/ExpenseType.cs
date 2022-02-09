namespace MinimalApiTest.Domain.Models
{
    public partial class ExpenseType
    {
        public long ExpenseTypeId { get; set; }
        public string? ExpenseTypeName { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ParentCategoryComponentId { get; set; }
        public long? CategoryComponentId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? SystaxCodeId { get; set; }
        public bool? System { get; set; }
        public string? Memo { get; set; }
        public long? ProjectItemId { get; set; }
        public decimal? MaximumClaim { get; set; }
        public bool? Travel { get; set; }
        public bool? Meals { get; set; }
        public bool? Accommodation { get; set; }
        public long? MinimumRequiredAttachments { get; set; }
        public long? MinimumRequiredAttachmentsNoReceipt { get; set; }
    }
}
