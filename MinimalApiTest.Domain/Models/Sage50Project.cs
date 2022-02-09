namespace MinimalApiTest.Domain.Models
{
    public partial class Sage50Project
    {
        public long Sage50ProjectId { get; set; }
        public string? Reference { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public short? StatusId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? CustomerRef { get; set; }
        public string? OrderNumber { get; set; }
        public string? Analysis1 { get; set; }
        public string? Analysis2 { get; set; }
        public string? Analysis3 { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? Address5 { get; set; }
        public string? ContactName { get; set; }
        public string? Telephone { get; set; }
        public string? Fax { get; set; }
        public string? EMail { get; set; }
        public string? CountryCode { get; set; }
        public decimal? TotalBilled { get; set; }
        public decimal? BilledNet { get; set; }
        public decimal? BilledTax { get; set; }
        public decimal? OutstandingToBill { get; set; }
        public decimal? PriceQuoted { get; set; }
        public decimal? ProfitToDate { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalBudget { get; set; }
        public decimal? Variance { get; set; }
        public DateTime? LastBilledDate { get; set; }
        public DateTime? LastCostDate { get; set; }
        public long? ProjectId { get; set; }
        public decimal? ParentProjectNo { get; set; }
        public decimal? ChildPosition { get; set; }
        public decimal? CommittedCost { get; set; }
        public DateTime? RecordCreateDate { get; set; }
        public DateTime? RecordModifyDate { get; set; }
        public bool? RecordDeleted { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
