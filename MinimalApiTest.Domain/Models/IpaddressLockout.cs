namespace MinimalApiTest.Domain.Models
{
    public partial class IpaddressLockout
    {
        public long IpaddressLockoutId { get; set; }
        public string? Username { get; set; }
        public string? Ipaddress { get; set; }
        public long? Attempts { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? LockoutDate { get; set; }
    }
}
