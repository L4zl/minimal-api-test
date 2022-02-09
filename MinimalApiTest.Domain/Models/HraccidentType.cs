namespace MinimalApiTest.Domain.Models
{
    public partial class HraccidentType
    {
        public long HraccidentTypeId { get; set; }
        public string? Description { get; set; }
        public bool? Deleted { get; set; }
        public bool? System { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
