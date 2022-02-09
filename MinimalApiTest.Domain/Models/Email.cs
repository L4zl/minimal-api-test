namespace MinimalApiTest.Domain.Models
{
    public partial class Email
    {
        public long EmailId { get; set; }
        public string? Recipient { get; set; }
        public string? Sender { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public DateTime? DateSent { get; set; }
        public bool? Failed { get; set; }
        public string? FailedReason { get; set; }
    }
}
