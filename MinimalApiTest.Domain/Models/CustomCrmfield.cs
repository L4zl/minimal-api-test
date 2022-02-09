namespace MinimalApiTest.Domain.Models
{
    public partial class CustomCrmfield
    {
        public long CustomCrmfieldId { get; set; }
        public int? CrmentityId { get; set; }
        public string? Description { get; set; }
        public int? Ordinal { get; set; }
    }
}
