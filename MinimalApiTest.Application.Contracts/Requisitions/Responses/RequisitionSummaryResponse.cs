namespace MinimalApiTest.Application.Contracts.Requisitions.Responses;

public class RequisitionSummaryResponse
{
    public long ID { get; set; }
    public decimal? NetValue { get; set; }
    public DateTime? OrderDate { get; set; }
    public string? OrderStatus { get; set; }
    public string? RequestedByName { get; set; }
    public string? RequestedFor { get; set; }
    public string? SageDatabaseName { get; set; }
    public string? Special { get; set; }
    public string? SupplierReference { get; set; }
    public string? SupplierName { get; set; }
    public string? PodocumentNumber { get; set; }
    public string? UpdatedUser { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? DeliveryPostalName { get; set; }
    public string? InvoicePostalName { get; set; }
}

