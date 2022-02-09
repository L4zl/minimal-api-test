namespace MinimalApiTest.Domain.Models
{
    public partial class UserCreditCardExpense
    {
        public long UserCreditCardExpenseId { get; set; }
        public long? UserId { get; set; }
        public long? CreditCardId { get; set; }
        public bool? IsDefault { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
