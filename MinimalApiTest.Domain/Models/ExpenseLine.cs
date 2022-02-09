namespace MinimalApiTest.Domain.Models
{
    public partial class ExpenseLine
    {
        public long ExpenseLineId { get; set; }
        public long? InvoiceLineId { get; set; }
        public long? LineNumber { get; set; }
        public long? ExpenseTypeId { get; set; }
        public long? SyscurrencyId { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public string? Notes { get; set; }
        public bool? Deleted { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? ExchangeRateAccount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountInAccountCurrency { get; set; }
        public decimal? AmountInBaseCurrency { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? ReceiptAttached { get; set; }
        public string? ExpensePaymentMethod { get; set; }
        public bool? FirstClass { get; set; }
        public bool? Alcohol { get; set; }
        public bool? GratuityIncluded { get; set; }
        public decimal? GratuityValue { get; set; }
        public string? SubsistenceType { get; set; }
        public string? SubsistenceDetail { get; set; }
        public string? EntertainmentType { get; set; }
        public string? EntertainmentDetail { get; set; }
        public bool? AllowNegativeAmounts { get; set; }
        public long? OrderLineId { get; set; }
        public bool? Subsistence { get; set; }
        public bool? Overnight { get; set; }
        public bool? Detention { get; set; }
        public bool? Conference { get; set; }
        public bool? Absence { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? SubsistenceGradeId { get; set; }
        public DateTime? ExpenseDateEndDate { get; set; }
        public decimal? SubsistenceRateStandard { get; set; }
        public int? SubsistenceRateStandardDays { get; set; }
        public decimal? SubsistenceRateConference { get; set; }
        public int? SubsistenceRateConferenceDays { get; set; }
        public decimal? SubsistenceRateDetention { get; set; }
        public int? SubsistenceRateDetentionDays { get; set; }
        public decimal? SubsistenceRateReduced { get; set; }
        public int? SubsistenceRateReducedDays { get; set; }
        public decimal? SubsistenceRateDayRate { get; set; }
        public bool? SubsistenceBreakfast { get; set; }
        public bool? SubsistenceLunch { get; set; }
        public bool? SubsistenceDinner { get; set; }
        public bool? SubsistenceAccommodation { get; set; }
        public bool? SubsistenceIncidentals { get; set; }
        public long? ExpenseMeetingId { get; set; }
        public long SubsistenceIncidentalId { get; set; }
    }
}
