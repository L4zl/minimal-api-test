namespace MinimalApiTest.Domain.Models
{
    public partial class SubsistenceRate
    {
        public long SubsistenceRateId { get; set; }
        public long? CountryId { get; set; }
        public long CityId { get; set; }
        public long? SubsistenceGradeId { get; set; }
        public string? CurrencyIsocode { get; set; }
        public decimal? OvernightStandardRate { get; set; }
        public decimal? OvernightReducedRate { get; set; }
        public decimal? OvernightDetentionRate { get; set; }
        public decimal? ConferenceRate { get; set; }
        public decimal? Day0HoursRate { get; set; }
        public decimal? Day5HoursRate { get; set; }
        public decimal? Day10HoursRate { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? BreakfastRateType { get; set; }
        public decimal? BreakfastRateDiscountPercentage { get; set; }
        public string? LunchRateType { get; set; }
        public decimal? LunchRateDiscountPercentage { get; set; }
        public string? DinnerRateType { get; set; }
        public decimal? DinnerRateDiscountPercentage { get; set; }
        public string? DualMealRateType { get; set; }
        public decimal? DualMealRateDiscountPercentage { get; set; }
        public bool? DinnerDiscount { get; set; }
        public string? AccommodationRateType { get; set; }
        public decimal? AccommodationRateDiscountPercentage { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
