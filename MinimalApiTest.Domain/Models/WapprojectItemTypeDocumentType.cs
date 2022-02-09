namespace MinimalApiTest.Domain.Models
{
    public partial class WapprojectItemTypeDocumentType
    {
        public long WapprojectItemTypeDocumentTypeId { get; set; }
        public long? WapprojectItemTypeId { get; set; }
        public bool? Deleted { get; set; }
        public string? DocumentType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
