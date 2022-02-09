namespace MinimalApiTest.Domain.Models
{
    public partial class Image
    {
        public long ImageId { get; set; }
        public string? Type { get; set; }
        public long? ForeignId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public byte[]? ImageData { get; set; }
        public string? FileExtension { get; set; }
    }
}
