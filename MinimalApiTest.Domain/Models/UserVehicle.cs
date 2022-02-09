namespace MinimalApiTest.Domain.Models
{
    public partial class UserVehicle
    {
        public long UserVehicleId { get; set; }
        public long? UserId { get; set; }
        public long? VehicleId { get; set; }
        public bool? IsDefault { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
