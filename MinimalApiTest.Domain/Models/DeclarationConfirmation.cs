namespace MinimalApiTest.Domain.Models
{
    public partial class DeclarationConfirmation
    {
        public long DeclarationConfirmationId { get; set; }
        public long? DeclarationId { get; set; }
        public long? UserId { get; set; }
        public long? ApprovableId { get; set; }
        public long? ApprovableItemId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
