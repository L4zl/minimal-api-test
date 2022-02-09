namespace MinimalApiTest.Domain.Models
{
    public partial class UserOrderTemplate
    {
        public long UserOrderTemplateId { get; set; }
        public long? UserId { get; set; }
        public string? Username { get; set; }
        public long? OrderTemplateId { get; set; }
        public string? OrderTemplateDescription { get; set; }
        public string? SageDatabaseName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
