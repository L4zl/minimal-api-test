namespace MinimalApiTest.Domain.Models
{
    public partial class UserMileageBalance
    {
        public long UserMileageBalanceId { get; set; }
        public long UserId { get; set; }
        public DateTime? BalanceDate { get; set; }
        public decimal? BusinessBalance { get; set; }
        public decimal? PersonalBalance { get; set; }
        public decimal? BusinessBalancePrivate { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
