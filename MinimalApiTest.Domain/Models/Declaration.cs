namespace MinimalApiTest.Domain.Models
{
    public partial class Declaration
    {
        public long DeclarationId { get; set; }
        public string? DocumentType { get; set; }
        public string? ApprovableTier { get; set; }
        public string? DeclarationText { get; set; }
        public string? InvoiceLineType { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
