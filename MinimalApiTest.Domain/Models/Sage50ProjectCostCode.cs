namespace MinimalApiTest.Domain.Models
{
    public partial class Sage50ProjectCostCode
    {
        public long Sage50ProjectCostCodeId { get; set; }
        public long? CostCodeId { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
        public long? CostTypeId { get; set; }
        public DateTime? RecordCreateDate { get; set; }
        public DateTime? RecordModifyDate { get; set; }
        public bool? RecordDeleted { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
