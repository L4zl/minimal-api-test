namespace MinimalApiTest.Domain.Models
{
    public partial class Sage50Currency
    {
        public long Sage50CurrencyId { get; set; }
        public long? Number { get; set; }
        public string? Code { get; set; }
        public string? Symbol { get; set; }
        public string? Name { get; set; }
        public short? EmuMember { get; set; }
        public short? BaseCurrency { get; set; }
        public decimal? Rate { get; set; }
        public string? MajorCurrencyUnit { get; set; }
        public string? MinorCurrencyUnit { get; set; }
        public short? RecordDeleted { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
