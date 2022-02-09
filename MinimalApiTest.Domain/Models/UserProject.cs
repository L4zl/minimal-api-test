namespace MinimalApiTest.Domain.Models
{
    public partial class UserProject
    {
        public long UserProjectId { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectItemId { get; set; }
        public long? UserId { get; set; }
        public long? SageDatabaseId { get; set; }
        public decimal? MaxLineValue { get; set; }
        public decimal? MaxAuthorisationValue { get; set; }
        public bool? Requisition { get; set; }
        public bool? Invoice { get; set; }
        public bool? Expense { get; set; }
        public bool? Timesheet { get; set; }
        public bool? HolidayRequest { get; set; }
        public bool? SalesOrder { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
