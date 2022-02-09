namespace MinimalApiTest.Domain.Models
{
    public partial class CsvimportFileInfo
    {
        public long CsvimportInfoId { get; set; }
        public string? FileName { get; set; }
        public long? FileSize { get; set; }
        public string? ImportType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
