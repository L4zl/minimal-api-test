namespace MinimalApiTest.Domain.Models;

public partial class BudgetEnquiry
{
    public long BudgetEnquiryId { get; set; }
    public long? SageDatabaseId { get; set; }
    public long? UserId { get; set; }
    public long? NlnominalAccountId { get; set; }
    public DateTime? Date { get; set; }
    public string? Type { get; set; }
    public long? PlsupplierAccountId { get; set; }
    public long? Urn { get; set; }
    public string? Reference { get; set; }
    public string? SecondReference { get; set; }
    public string? Ponumber { get; set; }
    public string? Description { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Net { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? UpdatedUser { get; set; }
    public string? NominalAccountName { get; set; }
    public string? NominalAccountNumber { get; set; }
    public string? NominalAccountCostCentre { get; set; }
    public string? NominalAccountDepartment { get; set; }
    public string? SupplierAccountNumber { get; set; }
    public string? SupplierAccountName { get; set; }
    public long? PeriodId { get; set; }
    public long? PeriodNumber { get; set; }
    public long? PeriodYear { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public string? OrderedBy { get; set; }
    public bool? Historical { get; set; }
}
