namespace MinimalApiTest.Domain.Models
{
    public partial class GoodsReceived
    {
        public long GoodsReceivedId { get; set; }
        public string? SupplierCode { get; set; }
        public string? SupplierGrn { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public decimal? QuantityReceived { get; set; }
        public bool? ReceivedInSage { get; set; }
        public string? Narrative { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string? Reference { get; set; }
        public long? SageDatabaseId { get; set; }
        public string? UpdateStatus { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? LineTypeId { get; set; }
        public long? ReceivedById { get; set; }
        public long? Wapgrnno { get; set; }
    }
}
