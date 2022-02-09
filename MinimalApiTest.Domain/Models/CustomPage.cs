namespace MinimalApiTest.Domain.Models
{
    public partial class CustomPage
    {
        public long CustomPageId { get; set; }
        public string? PageName { get; set; }
        public string? PageDescription { get; set; }
        public string? PageType { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
