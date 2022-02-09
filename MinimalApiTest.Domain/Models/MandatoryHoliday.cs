namespace MinimalApiTest.Domain.Models
{
    public partial class MandatoryHoliday
    {
        public long MandatoryHolidayId { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public string? Type { get; set; }
        public decimal? Days { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? CountryId { get; set; }
    }
}
