namespace MinimalApiTest.Domain.Models
{
    public partial class ConstructionValuationLine
    {
        public long ConstructionValuationLineId { get; set; }
        public long? ConstructionValuationId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectHeaderId { get; set; }
        public long? PhaseId { get; set; }
        public long? StageId { get; set; }
        public long? ActivityId { get; set; }
        public long? TaxCodeId { get; set; }
        public long? NominalAccountId { get; set; }
        public string? NominalName { get; set; }
        public string? NominalCostCentre { get; set; }
        public string? NominalDepartment { get; set; }
        public string? NominalReference { get; set; }
        public string? TaxCodeString { get; set; }
        public string? Narrative { get; set; }
        public decimal? NetValue { get; set; }
        public decimal? ApplicationValue { get; set; }
        public decimal? TaxValue { get; set; }
        public bool? Deleted { get; set; }
    }
}
