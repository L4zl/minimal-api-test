namespace MinimalApiTest.Domain.Models
{
    public partial class Version
    {
        public long VersionId { get; set; }
        public string? VersionNumber { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
