namespace MinimalApiTest.Domain.Models
{
    public partial class Theme
    {
        public long ThemeId { get; set; }
        public string? Name { get; set; }
        public bool? Selectable { get; set; }
        public bool? DefaultTheme { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
