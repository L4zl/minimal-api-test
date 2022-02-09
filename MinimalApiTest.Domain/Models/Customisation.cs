namespace MinimalApiTest.Domain.Models
{
    public partial class Customisation
    {
        public long CustomisationId { get; set; }
        public string? ParentContainer { get; set; }
        public string? ControlName { get; set; }
        public string? Text { get; set; }
        public string? ToolTip { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
