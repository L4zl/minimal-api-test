namespace MinimalApiTest.Domain.Models
{
    public partial class UserSupplierFilterCode
    {
        public long UserSupplierFilterCodeId { get; set; }
        public long SageDatabaseId { get; set; }
        public long UserId { get; set; }
        public long SupplierFilterCodeId { get; set; }
        public bool? IsDefault { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
