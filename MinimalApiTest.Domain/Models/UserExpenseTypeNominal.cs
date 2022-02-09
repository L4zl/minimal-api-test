namespace MinimalApiTest.Domain.Models
{
    public partial class UserExpenseTypeNominal
    {
        public long UserExpenseTypeNominalId { get; set; }
        public long? UserExpenseTypeId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public string? Memo { get; set; }
        public bool? IsUserDefault { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
