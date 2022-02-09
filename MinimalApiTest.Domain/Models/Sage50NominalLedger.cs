namespace MinimalApiTest.Domain.Models
{
    public partial class Sage50NominalLedger
    {
        public long Sage50NominalLedgerId { get; set; }
        public string? AccountRef { get; set; }
        public string? Name { get; set; }
        public long? DepartmentNumber { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentReference { get; set; }
        public long? AccountType { get; set; }
        public long? SageDatabaseId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
