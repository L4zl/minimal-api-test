namespace MinimalApiTest.Domain.Models
{
    public partial class WapprojectItemType
    {
        public long WapprojectItemTypeId { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
