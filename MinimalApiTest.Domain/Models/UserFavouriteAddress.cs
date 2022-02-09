namespace MinimalApiTest.Domain.Models
{
    public partial class UserFavouriteAddress
    {
        public long UserFavouriteAddressId { get; set; }
        public long UserId { get; set; }
        public string? AddressDescription { get; set; }
        public string? AddressDetail { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
