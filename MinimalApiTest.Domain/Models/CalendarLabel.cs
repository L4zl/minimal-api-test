namespace MinimalApiTest.Domain.Models
{
    public partial class CalendarLabel
    {
        public long CalendarLabelId { get; set; }
        public long? SlotNumber { get; set; }
        public string? Name { get; set; }
        public string? DisplayName { get; set; }
        public string? Colour { get; set; }
        public string? CalendarSource { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
