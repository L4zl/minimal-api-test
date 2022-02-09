namespace MinimalApiTest.Domain.Models
{
    public partial class FuelRateCutoffSageDatabase
    {
        public long FuelRateCutoffSageDatabaseId { get; set; }
        public long FuelRateCutoffId { get; set; }
        public long SageDatabaseId { get; set; }
        public long TscategoryComponentId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
