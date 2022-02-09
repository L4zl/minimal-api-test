﻿namespace MinimalApiTest.Domain.Models
{
    public partial class ProjectRequisition
    {
        public long ProjectRequisitionId { get; set; }
        public long? RequestedById { get; set; }
        public long? DeliveryAddressId { get; set; }
        public long? InvoiceAddressId { get; set; }
        public long? SageDatabaseId { get; set; }
        public long? DepartmentId { get; set; }
        public string? DocumentStatus { get; set; }
        public string? UpdateStatus { get; set; }
        public string? UrgentReason { get; set; }
        public string? SageDatabaseName { get; set; }
        public string? RequestedByName { get; set; }
        public string? DeliveryAddressName { get; set; }
        public string? UpdatedUser { get; set; }
        public string? InvoicePostalName { get; set; }
        public string? InvoiceAddressLine1 { get; set; }
        public string? InvoiceAddressLine2 { get; set; }
        public string? InvoiceAddressLine3 { get; set; }
        public string? InvoiceAddressLine4 { get; set; }
        public string? InvoicePostCode { get; set; }
        public string? InvoiceContactName { get; set; }
        public string? InvoiceTelephoneNo { get; set; }
        public string? InvoiceFaxNo { get; set; }
        public string? DeliveryPostalName { get; set; }
        public string? DeliveryAddressLine1 { get; set; }
        public string? DeliveryAddressLine2 { get; set; }
        public string? DeliveryAddressLine3 { get; set; }
        public string? DeliveryAddressLine4 { get; set; }
        public string? DeliveryPostCode { get; set; }
        public string? DeliveryContactName { get; set; }
        public string? DeliveryTelephoneNo { get; set; }
        public string? DeliveryFaxNo { get; set; }
        public string? Notes { get; set; }
        public string? Comments { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? FullyApprovedDate { get; set; }
        public bool? Urgent { get; set; }
        public bool? Deleted { get; set; }
        public bool? HasAnalysisValues { get; set; }
        public bool? HasAttachments { get; set; }
        public bool? Archived { get; set; }
        public bool? IsDummy { get; set; }
        public string? Analysis1 { get; set; }
        public string? Analysis2 { get; set; }
        public string? Analysis3 { get; set; }
        public string? Analysis4 { get; set; }
        public string? Analysis5 { get; set; }
        public string? Analysis6 { get; set; }
        public string? Analysis7 { get; set; }
        public string? Analysis8 { get; set; }
        public string? Analysis9 { get; set; }
        public string? Analysis10 { get; set; }
        public string? Analysis11 { get; set; }
        public string? Analysis12 { get; set; }
        public string? Analysis13 { get; set; }
        public string? Analysis14 { get; set; }
        public string? Analysis15 { get; set; }
        public string? Analysis16 { get; set; }
        public string? Analysis17 { get; set; }
        public string? Analysis18 { get; set; }
        public string? Analysis19 { get; set; }
        public string? Analysis20 { get; set; }
        public string? ApprovalComments { get; set; }
        public bool? OnHold { get; set; }
        public string? OnHoldReason { get; set; }
        public long? DefaultProject { get; set; }
        public long? DefaultProjectItem { get; set; }
        public long? DefaultProjectPhase { get; set; }
        public long? DefaultProjectStage { get; set; }
        public long? DefaultProjectSubStage { get; set; }
        public long? DefaultNominalAccountId { get; set; }
    }
}