namespace MinimalApiTest.Domain.Models
{
    public partial class DocumentType
    {
        public long DocumentTypeId { get; set; }
        public string? DocumentType1 { get; set; }
        public string? Description { get; set; }
        public bool? IsModule { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
