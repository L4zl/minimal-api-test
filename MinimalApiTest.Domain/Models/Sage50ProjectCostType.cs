namespace MinimalApiTest.Domain.Models
{
    public partial class Sage50ProjectCostType
    {
        public long Sage50ProjectCostTypeId { get; set; }
        public long? CostTypeId { get; set; }
        public string? Name { get; set; }
        public bool? IsDefault { get; set; }
        public DateTime? RecordCreateDate { get; set; }
        public DateTime? RecordModifyDate { get; set; }
        public bool? RecordDeleted { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
