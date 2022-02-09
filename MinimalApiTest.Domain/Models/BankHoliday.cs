namespace MinimalApiTest.Domain.Models
{
    public partial class BankHoliday
    {
        public long BankHolidayId { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? CountryId { get; set; }
    }
}
