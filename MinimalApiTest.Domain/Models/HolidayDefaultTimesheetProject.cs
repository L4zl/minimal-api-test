namespace MinimalApiTest.Domain.Models
{
    public partial class HolidayDefaultTimesheetProject
    {
        public long HolidayDefaultTimesheetProjectId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectItemId { get; set; }
        public long? CostRateTypeId { get; set; }
        public long? ChargeRateTypeId { get; set; }
        public long? PayRateTypeId { get; set; }
        public long? UserId { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? Type { get; set; }
    }
}
