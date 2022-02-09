namespace MinimalApiTest.Domain.Models
{
    public partial class OrderTemplate
    {
        public long OrderTemplateId { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? SageDatabaseName { get; set; }
        public long? DefaultWarehouseId { get; set; }
        public string? TemplateDescription { get; set; }
        public bool? Deleted { get; set; }
        public long? CreatedById { get; set; }
        public string? CreatedByName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
