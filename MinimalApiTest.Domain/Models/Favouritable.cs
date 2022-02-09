namespace MinimalApiTest.Domain.Models
{
    public partial class Favouritable
    {
        public long FavouritableId { get; set; }
        public string? ParentContainer { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Value { get; set; }
        public string? ToolTip { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
