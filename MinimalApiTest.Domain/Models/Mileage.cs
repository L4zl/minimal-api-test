namespace MinimalApiTest.Domain.Models
{
    public partial class Mileage
    {
        public long MileageId { get; set; }
        public long? InvoiceLineId { get; set; }
        public DateTime? MileageDate { get; set; }
        public string? JourneyDetails { get; set; }
        public decimal? StartMileage { get; set; }
        public decimal? EndMileage { get; set; }
        public decimal? TotalMileage { get; set; }
        public decimal? BusinessMileage { get; set; }
        public decimal? PersonalMileage { get; set; }
        public decimal? UserCurrentMileage { get; set; }
        public long? UserId { get; set; }
        public long? FuelRateId { get; set; }
        public long? FuelRateHistoryId { get; set; }
        public decimal? PencePerMile { get; set; }
        public string? VehicleRegistration { get; set; }
        public long? VehicleId { get; set; }
        public bool? Deleted { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? SysfinancialYearId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? ReceiptAttached { get; set; }
        public long? CategoryComponentId { get; set; }
        public long? ParentCategoryComponentId { get; set; }
        public bool? YearEndRun { get; set; }
        public long? NumberOfPassengers { get; set; }
        public decimal? PassengerPencePerMile { get; set; }
        public long? FuelPencePerMile { get; set; }
        public long? LineNumber { get; set; }
        public decimal? BusinessMileageAdjustment { get; set; }
        public string? BusinessMileageAdjustmentReason { get; set; }
        public long? CustomRateIndex { get; set; }
        public bool? IncludeInCutoffCalculation { get; set; }
        public string? JourneyWaypoints { get; set; }
        public long? ExpenseMeetingId { get; set; }
    }
}
