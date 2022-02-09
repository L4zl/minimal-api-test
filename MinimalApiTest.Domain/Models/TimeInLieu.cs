namespace MinimalApiTest.Domain.Models
{
    public partial class TimeInLieu
    {
        public long TimeInLieuId { get; set; }
        public long? UserId { get; set; }
        public decimal? AdjustmentValue { get; set; }
        public string? AdjustmentType { get; set; }
        public string? SourceModule { get; set; }
        public long? SourceForeignId { get; set; }
        public long? SourceForeignChildId { get; set; }
        public string? Narrative { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
