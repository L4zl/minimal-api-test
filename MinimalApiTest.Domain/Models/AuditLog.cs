namespace MinimalApiTest.Domain.Models
{
    public partial class AuditLog
    {
        public long AuditLogId { get; set; }
        public string? DocumentType { get; set; }
        public string? ClassFullName { get; set; }
        public string? DocumentStatus { get; set; }
        public long? ApprovableParentKey { get; set; }
        public long? ApprovableKey { get; set; }
        public long? ForeignParentKey { get; set; }
        public long? ForeignKey { get; set; }
        public long? UpdatedUserId { get; set; }
        public string? AuditAction { get; set; }
        public string? PropertyDescription { get; set; }
        public string? OriginalValue { get; set; }
        public string? ModifiedValue { get; set; }
        public string? LoggedInUser { get; set; }
        public string? ItemDescription { get; set; }
        public string? AuditDescription { get; set; }
        public string? CallStack { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? Description { get; set; }
    }
}
