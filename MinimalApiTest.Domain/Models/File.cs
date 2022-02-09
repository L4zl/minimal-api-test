namespace MinimalApiTest.Domain.Models
{
    public partial class File
    {
        public long FileId { get; set; }
        public string? FileName { get; set; }
        public string? ContentType { get; set; }
        public long? ContentLength { get; set; }
        public long? ForeignKey { get; set; }
        public long? ForeignChildKey { get; set; }
        public string? FileSource { get; set; }
        public byte[]? FileData { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? OriginalFileName { get; set; }
        public bool? PostedToSage { get; set; }
        public Guid FileGuid { get; set; }
    }
}
